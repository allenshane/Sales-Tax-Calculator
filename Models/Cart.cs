using System.Collections.Generic;
using System.Linq;

namespace SalesTaxCalculator
{
    public class Cart
    {
        public IList<CartItems> CartItems { get; set; }
        public decimal TotalTax { get { return CartItems.Sum(x => x.Tax); } }
        public decimal TotalCost { get { return CartItems.Sum(x => x.Cost); } }
    }
}