using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Single Responsibility Principle (The S in SOLID)
//  There should be only one reason to change the class.
*/
namespace SRPDemo
{
    class Program
    {
        /// <summary>
        /// It controls the flow of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            StandardMessages.WelcomeMessage();

            // Ask for user information
            var user = PersonDataCapture.Capture();

            // Checks to be sure the first and last names are valid
            var isPersonValid = PersonValidator.Validate(user);

            if (isPersonValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }  

            //Create a username for the person 
            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
    }
}
