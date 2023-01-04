using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    using DependencyInjectionLibrary;

    public class Application : IApplication
    {
        private IBussinessLogic _bussinessLogic;

        public Application(IBussinessLogic bussinessLogic)
        {
            this._bussinessLogic = bussinessLogic;
        }

        public void Run()
        {
            this._bussinessLogic.ProcessData();
        }
    }
}
