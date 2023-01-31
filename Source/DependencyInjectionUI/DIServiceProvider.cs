using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    using System.Reflection;

    public class DIServiceProvider : IDIServiceProvider, IDisposable, IServiceProvider
    {
        private Dictionary<Type, object> references = new Dictionary<Type, object>();
        private Dictionary<Type, Type> transientServiceRegistrations = new Dictionary<Type, Type>();
        private Dictionary<Type, Type> singletonServiceRegistrations = new Dictionary<Type, Type>();

        public static IDIServiceProvider CurrentServiceProvider { get; set; }

        public DIServiceProvider()
        {
            this.AddReference<IDIServiceProvider>((IDIServiceProvider)this);
            this.AddReference<IServiceProvider>((IServiceProvider)this);
            DIServiceProvider.CurrentServiceProvider = (IDIServiceProvider)this;
        }

        public IDIServiceProvider AddReference<TReferenceType>(TReferenceType service) => this.AddReference<TReferenceType, TReferenceType>(service);

        public virtual IDIServiceProvider AddReference<TBase, TReferenceType>(
          TReferenceType service)
        {
            if (!this.IsRegistered(typeof(TBase), typeof(TReferenceType)))
            {
                this.RemoveService(typeof(TBase));
                lock (this.references)
                    this.references[typeof(TBase)] = (object)service;
            }
            return (IDIServiceProvider)this;
        }

        public IDIServiceProvider AddSingleton<TBase, TService>() => this.AddSingleton(typeof(TBase), typeof(TService));

        public virtual IDIServiceProvider AddSingleton(Type tBase, Type tService)
        {
            if (!this.IsRegistered(tBase, tService))
            {
                this.RemoveService(tBase);
                lock (this.singletonServiceRegistrations)
                    this.singletonServiceRegistrations[tBase] = tService;
            }
            return (IDIServiceProvider)this;
        }

        public IDIServiceProvider AddSingleton<TService>() => this.AddSingleton(typeof(TService), typeof(TService));

        public IDIServiceProvider AddSingleton(Type tService) => this.AddSingleton(tService, tService);

        public IDIServiceProvider AddTransient<TBase, TService>() => this.AddTransient(typeof(TBase), typeof(TService));

        public virtual IDIServiceProvider AddTransient(Type tBase, Type tService)
        {
            if (!this.IsRegistered(tBase, tService))
            {
                this.RemoveService(tBase);
                lock (this.transientServiceRegistrations)
                    this.transientServiceRegistrations[tBase] = tService;
            }
            return (IDIServiceProvider)this;
        }

        public IDIServiceProvider AddTransient<TService>() => this.AddTransient(typeof(TService), typeof(TService));

        public IDIServiceProvider AddTransient(Type tService) => this.AddTransient(tService, tService);

        public bool IsRegistered<T>() => this.IsRegistered(typeof(T));

        public virtual bool IsRegistered(Type t)
        {
            lock (this.references)
            {
                if (this.references.ContainsKey(t))
                    return true;
            }
            lock (this.singletonServiceRegistrations)
            {
                if (this.singletonServiceRegistrations.ContainsKey(t))
                    return true;
            }
            lock (this.transientServiceRegistrations)
            {
                if (this.transientServiceRegistrations.ContainsKey(t))
                    return true;
            }
            return false;
        }

        private bool IsRegistered(Type tKey, Type tValue)
        {
            lock (this.references)
            {
                object obj;
                if (this.references.TryGetValue(tKey, out obj))
                {
                    if (obj.GetType() == tValue)
                        return true;
                }
            }
            lock (this.singletonServiceRegistrations)
            {
                Type type;
                if (this.singletonServiceRegistrations.TryGetValue(tKey, out type))
                {
                    if (type == tValue)
                        return true;
                }
            }
            lock (this.transientServiceRegistrations)
            {
                Type type;
                if (this.transientServiceRegistrations.TryGetValue(tKey, out type))
                {
                    if (type == tValue)
                        return true;
                }
            }
            return false;
        }

        public virtual object GetService(Type t)
        {
            lock (this.references)
            {
                object service;
                if (this.references.TryGetValue(t, out service))
                    return service;
            }
            Type t1;
            bool flag;
            lock (this.singletonServiceRegistrations)
                flag = this.singletonServiceRegistrations.TryGetValue(t, out t1);
            if (flag)
            {
                object service = this.InstanciateType(t1);
                lock (this.references)
                    this.references[t] = service;
                return service;
            }
            lock (this.transientServiceRegistrations)
                flag = this.transientServiceRegistrations.TryGetValue(t, out t1);
            if (flag)
                return this.InstanciateType(t1);
            throw new ObjectNotRegisteredException("The service " + t.Name + " is not registered!");
        }

        protected virtual object InstanciateType(Type t)
        {
            ConstructorInfo[] constructors = t.GetConstructors();
            Array.Sort<ConstructorInfo>(constructors, (Comparison<ConstructorInfo>)((x, y) => -1 * x.GetParameters().Length.CompareTo(y.GetParameters().Length)));
            foreach (MethodBase methodBase in constructors)
            {
                ParameterInfo[] parameters = methodBase.GetParameters();
                bool flag = true;
                for (int index = 0; index < parameters.Length; ++index)
                {
                    if (!this.IsRegistered(parameters[index].ParameterType))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    object[] objArray = new object[parameters.Length];
                    for (int index = 0; index < objArray.Length; ++index)
                        objArray[index] = this.GetService(parameters[index].ParameterType);
                    return Activator.CreateInstance(t, objArray);
                }
            }
            throw new ObjectNotRegisteredException("No contructor of " + t.Name + " maches any registered services.");
        }

        public T GetService<T>() => (T)this.GetService(typeof(T));

        public void Dispose()
        {
            if (DIServiceProvider.CurrentServiceProvider == this)
                DIServiceProvider.CurrentServiceProvider = (IDIServiceProvider)null;
            lock (this.references)
            {
                foreach (IDisposable disposable in this.references.Values.OfType<IDisposable>())
                {
                    if (disposable != this)
                        disposable.Dispose();
                }
                this.references.Clear();
            }
            lock (this.singletonServiceRegistrations)
                this.singletonServiceRegistrations.Clear();
            lock (this.transientServiceRegistrations)
                this.transientServiceRegistrations.Clear();
        }

        public virtual IDIServiceProvider RemoveService(Type t)
        {
            object obj;
            bool flag;
            lock (this.references)
            {
                flag = this.references.TryGetValue(t, out obj);
                this.references.Remove(t);
            }
            if (flag)
            {
                if (obj is IDisposable disposable)
                {
                    try
                    {
                        disposable.Dispose();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            lock (this.singletonServiceRegistrations)
            {
                if (this.singletonServiceRegistrations.TryGetValue(t, out Type _))
                    this.singletonServiceRegistrations.Remove(t);
            }
            lock (this.transientServiceRegistrations)
            {
                if (this.transientServiceRegistrations.TryGetValue(t, out Type _))
                    this.transientServiceRegistrations.Remove(t);
            }
            return (IDIServiceProvider)this;
        }

        public IDIServiceProvider RemoveService<T>() => this.RemoveService(typeof(T));
    }

    public class ObjectNotRegisteredException : Exception
    {
        public ObjectNotRegisteredException()
        {
        }

        public ObjectNotRegisteredException(string msg)
            : base(msg)
        {
        }
    }
}
