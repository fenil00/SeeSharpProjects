using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemoUI
{
    using DILibrary;

    /// <summary>
    /// Dependency Inversion Principle (The D in SOLID)
    /// High level modules should not depend on low level modules but rather both should depend on abstractions and those abstractions should not depend on details.
    /// High level modules -> anything that calls something.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Fenil";
            owner.LastName = "Desai";
            owner.EmailAddress = "fenil@iamfenildesai.com";
            owner.PhoneNumber = "121222" ;

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
