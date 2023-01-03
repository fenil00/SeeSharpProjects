using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCDemoUI
{
    using OPCLibrary;
    
    /* Open Closed Principle 
    //  Closed for modification but open for extension
    // If Code is working don't modify and introduce new bugs 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            List<IApplicantModel> applicants = new List<IApplicantModel>
                                               {
                                                   new PersonModel { FirstName = "Fenil", LastName = "Desai" },
                                                   new ExecutiveModel() { FirstName = "Sue", LastName = "Storm" },
                                                   new ManagerModel() { FirstName = "Nancy", LastName = "Roman"}
                                               };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} IsManager : {emp.IsManager} IsExecutive : {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
