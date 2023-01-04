using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionUI
{
    using DependencyInjectionLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            BussinessLogic bussinessLogic = new BussinessLogic();

            bussinessLogic.ProcessData();

            Console.ReadLine();
        }
    }
}
