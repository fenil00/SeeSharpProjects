using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    using System.Reflection;

    using Autofac;
    using Autofac.Core;

    using DependencyInjectionLibrary;

    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            // It is container to store all the definitions we want to instantiate.
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();

            // It will register "BussinessLogic" class and whenever you will look for "IBussinessLogic" it will return the instance of "BussinessLogic". 
            builder.RegisterType<BussinessLogic>().As<IBussinessLogic>();

            // In the "Utilities" folder get the all classes, register them and linked with the its match interfaces
            // Logger -> ILogger, DataAccess -> IDataAccess
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependencyInjectionLibrary)))
                .Where(t => t.Namespace.Contains("Utilities"))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
