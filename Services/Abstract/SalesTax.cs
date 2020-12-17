using System;

namespace SalesTaxCalculator
{
    public abstract class SalesTax
    {
        abstract public bool IsApplicable(Product item);
        abstract public decimal Rate { get; }

        public decimal Calculate(Product item)
        {
            if (IsApplicable(item))
            {
                //sales tax are such that for a tax rate of n%, a shelf price of p contains (np/100)
                var tax = (item.ShelfPrice * Rate) / 100;

                //Value rounded to the nearest 0.05
                tax = Math.Ceiling(tax / 0.05m) * 0.05m;

                return tax;
            }

            return 0;
        }
    }
}