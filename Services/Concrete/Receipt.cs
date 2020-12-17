using System;

namespace SalesTaxCalculator
{
    public class Receipt
    {
        public static void Print(Cart cart)
        {
            //prints the items in the following format => 1 chocolate bar: 0.85
            foreach (var cartItem in cart.CartItems)
            {
                Console.WriteLine(cartItem.ToString());
            }

            //prints the sales tax in the following format => Taxes: 1.50
            Console.WriteLine("Taxes: {0:N2}", cart.TotalTax);

            //prints the total in the following format => Total: 29.83
            Console.WriteLine("Total: {0:N2}", cart.TotalCost);
        }
    }
}