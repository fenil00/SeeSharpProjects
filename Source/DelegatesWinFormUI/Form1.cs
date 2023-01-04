using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatesWinFormUI
{
    using DelegatesLibrary;

    public partial class Form1 : Form
    {
        ShoppingCartModel cart = new ShoppingCartModel();

        public Form1()
        {
            InitializeComponent();
            this.PopulateCartWithDemoData();
        }

        private void MessageBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = this.cart.GenerateTotal(
                this.SubTotalAlert,
                this.CalulateLeveledDiscount,
                this.PrintOutDiscountAlert);

            MessageBox.Show($"the total is {total:C2}");
        }

        private void TextBoxDemoButton_Click(object sender, EventArgs e)
        {
            decimal total = cart.GenerateTotal((subTotal) => textBoxSubtotal.Text = $"{subTotal:C2}",
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
                (act) => {  });

            textBoxTotal.Text = $"{total:C2}";
        }

        private void PrintOutDiscountAlert(string message)
        {
            MessageBox.Show(message);
        }

        private void SubTotalAlert(decimal subtotal)
        {
            MessageBox.Show($"The subtotal is {subtotal:C2}");
        }

        private decimal CalulateLeveledDiscount(List<ProductModel> products, decimal subTotal)
        {
            
            return subTotal - products.Count();
            
        }

        private void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel() { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel() { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel() { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel() { ItemName = "Blueberries", Price = 10.63M });
        }
    }
}
