using System.Linq;

namespace SalesTaxCalculator
{
    public class TaxCalculator
    {
        private SalesTax[] Taxes = new SalesTax[]
        {
            new BasicSalesTax(),
            new ImportedDutySalesTax()
        };

        public void Calculate(Cart cart)
        {
            foreach (var cartItem in cart.CartItems)
            {
                cartItem.Tax = Taxes.Sum(x => x.Calculate(cartItem.Product));
            }
        }
    }
}