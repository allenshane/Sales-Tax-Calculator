using System.Linq;

namespace SalesTaxCalculator
{
    public class BasicSalesTax : SalesTax
    {
        private ProductType[] taxExemptions = new[] { ProductType.Food, ProductType.Medical, ProductType.Book };

        public override bool IsApplicable(Product item)
        {
            return !(taxExemptions.Any(x => item.IsTypeOf(x)));
        }

        public override decimal Rate { get { return 10.00M; } }
    }
}