using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SalesTaxCalculator
{
    public class InputProcessor
    {
        private static readonly string itemRegex = "(\\d+) ([\\w\\s]* )at (\\d+.\\d{2})";

        private static Cart Parse(string[] listOfItemsWithDescription)
        {
            return new Cart
            {
                CartItems = listOfItemsWithDescription.Select(Parse).ToList(),
            };
        }

        public static void ProcessInput(string[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var cart = Parse(input);

            var taxCalculator = new TaxCalculator();
            taxCalculator.Calculate(cart);

            Receipt.Print(cart);
        }

        private static CartItems Parse(string itemFullDescription)
        {
            var regex = new Regex(itemRegex);
            var match = regex.Match(itemFullDescription);
            if (match.Success)
            {
                var quantity = int.Parse(match.Groups[1].Value);
                var price = decimal.Parse(match.Groups[3].Value);

                var itemName = match.Groups[2].Value.Trim();

                var cartItem = new CartItems
                {
                    Quantity = quantity,
                    Product = new Product { Name = itemName, ShelfPrice = price }
                };

                return cartItem;
            }

            return null;
        }
    }
}