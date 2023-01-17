using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();


        public decimal GenerateTotal(MentionDiscount mentionSubtotal,
                                     Func<List<ProductModel>,decimal,decimal> calulateDiscountedTotal,
                                     Action<string> tellUserWeAreDiscounting)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            mentionSubtotal(subTotal);

            // Below both are okay.
            // tellUserWeAreDiscounting("We are applying your discount.");
            tellUserWeAreDiscounting?.Invoke("We are applying your discount.");

            return calulateDiscountedTotal(Items, subTotal);
            
        }
    }
}
