using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODemoApp
{
    public class RentalVehicle
    {
        public int RentalId { get; set; }

        public string CurrentRenter { get; set; }

        public decimal PricePerDay { get; set; }

        public int NumberOfPassengers { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Turn Key to ignition setting.");
            Console.WriteLine("Turn Key to on.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Turn key to off");
        }
    }
}
