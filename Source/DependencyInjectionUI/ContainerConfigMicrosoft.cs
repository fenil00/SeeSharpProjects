using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    using System.ComponentModel.Design;

    using DependencyInjectionLibrary;
    using DependencyInjectionLibrary.Utilities;

    public static class ContainerConfigMicrosoft 
    {
        public static IServiceContainer Configure()
        {

            var builder = new ServiceContainer();

            var logger = new Logger();
            builder.AddService(typeof(ILogger), logger);

            var dataAccess = new DataAccess(logger);
            builder.AddService(typeof(IDataAccess), dataAccess);

            var bussinessLogic = new BussinessLogic(logger, dataAccess);


            builder.AddService(typeof(IBussinessLogic), bussinessLogic);
            builder.AddService(typeof(IApplication), new Application(bussinessLogic));


            return builder;
        }
    }
}
