using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    using Autofac;

    using DependencyInjectionLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            //Dependency Inversion 
            //Top level Object is going to control all the dependencies.

            // BussinessLogic bussinessLogic = new BussinessLogic();
            // bussinessLogic.ProcessData();

            var container = ContainerConfig.Configure();

            // new scope for instances being passed out. 
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();

                // It will give instance of "Application" but Application requires "IBussinessLogic"
                // then get instance of "BussinessLogic" -> but it requires "ILogger" and "IDataAccess" -> 
                // then get instance of "Logger" and "DataAccess"

                app.Run();
            }

            Console.ReadLine();
        }
    }
}
