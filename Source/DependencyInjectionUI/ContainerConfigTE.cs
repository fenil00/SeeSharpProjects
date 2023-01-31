using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    using DependencyInjectionLibrary;
    using DependencyInjectionLibrary.Utilities;

    public static class ContainerConfigTE
    {

        public static IDIServiceProvider Configure()
        {
            var builder = new DIServiceProvider();

            builder.AddSingleton(typeof(ILogger), typeof(Logger));
            builder.AddSingleton(typeof(IDataAccess), typeof(DataAccess));
            builder.AddSingleton(typeof(IBussinessLogic), typeof(BussinessLogic));
            builder.AddSingleton(typeof(IApplication), typeof(Application));

            return builder;
        }
    }
}
