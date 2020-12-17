using System;

namespace SalesTaxCalculator
{
    public class ImportedDutySalesTax : SalesTax
    {
        public override bool IsApplicable(Product item)
        {
            return item.IsImported;
        }

        public override decimal Rate { get { return 5.00M; } }
    }
}