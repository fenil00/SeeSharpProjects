using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    public interface IDIServiceProvider : IDisposable, IServiceProvider
    {
        IDIServiceProvider AddReference<TReferenceType>(TReferenceType service);

        IDIServiceProvider AddReference<TBase, TReferenceType>(TReferenceType service);

        IDIServiceProvider AddSingleton<TBase, TService>();

        IDIServiceProvider AddTransient<TBase, TService>();

        IDIServiceProvider AddSingleton(Type tBase, Type tService);

        IDIServiceProvider AddTransient(Type tBase, Type tService);

        IDIServiceProvider AddSingleton<TService>();

        IDIServiceProvider AddTransient<TService>();

        IDIServiceProvider AddSingleton(Type tService);

        IDIServiceProvider AddTransient(Type tService);

        T GetService<T>();

        bool IsRegistered<T>();

        bool IsRegistered(Type t);

        IDIServiceProvider RemoveService(Type t);

        IDIServiceProvider RemoveService<T>();
    }
}
