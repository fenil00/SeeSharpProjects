using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemoUI
{
    using ISPLibrary;

    /// Interface Segregation Principle (The I in SOLID)
    /// Client should not be depend on Interfaces they don't use.
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();

            Console.ReadLine();
        }
    }
}
