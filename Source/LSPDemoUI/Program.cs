using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoUI
{
    using LSPLibrary;

    /// <summary>
    /// Liskov Substitution Principle (The L in SOLID)
    /// If S is a subtype of T then object of type T maybe replaced with object of Type S without breaking the program. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Manager();
            emp.FirstName = "Fenil";
            emp.LastName = "Desai";
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            Console.ReadLine();
        }
    }
}
