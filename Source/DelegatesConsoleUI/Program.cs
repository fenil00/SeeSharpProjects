using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConsoleUI
{
    using System.Globalization;

    using DelegatesLibrary;

    class Program
    {
        private static ShoppingCartModel cart = new ShoppingCartModel();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            PopulateCartWithDemoData();

             Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalulateLeveledDiscount, AlertUser):C2}");

             Console.WriteLine();

            decimal total = cart.GenerateTotal((subTotal) => Console.WriteLine($"Subtotal for cart 2 is {subTotal:C2}"),
                 (prodcuts, subtotal) =>
                     {
                         if (prodcuts.Count > 3)
                         {
                             return subtotal * 0.5M;
                         }
                         else
                         {
                             return subtotal;
                         }
                     },
                 (act) => Console.WriteLine($"Cart 2 Alert: {act}"));

             Console.WriteLine($"The total for car 2 is {total:C2}");

             Console.WriteLine();
             Console.Write("Please press any key to exit the application...");
             Console.ReadKey();
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }

        private static decimal CalulateLeveledDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.95M;
            }
            else
            {
                return subTotal;
            }
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel(){ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel() { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel() { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel() { ItemName = "Blueberries", Price = 10.63M });
        }
    }
}
