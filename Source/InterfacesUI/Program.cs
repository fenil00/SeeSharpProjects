using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesUI
{
    using InterfacesLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (var prod in cart)
            {
                prod.ShipItem(customer);

                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have {digital.TotalDownloadsLeft} downloads left.");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel() { FirstName = "Fenil", LastName = "Desai", City = "Munich", EmailAddress = "fenil@iamfenildesai.com", PhoneNumber = "555-1231"};
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel(){ Title = "Nerf Football" });
            output.Add(new PhysicalProductModel() { Title = "T-shirt" });
            output.Add(new PhysicalProductModel() { Title = "Hard Drive" });
            output.Add(new DigitalProductModel() { Title = "Subscription of iTune" });
            output.Add(new CourseProductModel() {Title = ".NET Core start to finish"});

            return output;
        }
    }
}
