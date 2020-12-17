using System.Collections.Generic;
using System.Linq;

namespace SalesTaxCalculator
{
    public class Product
    {
        private static readonly IDictionary<ProductType, string[]> itemTypeIdentifiers = new Dictionary<ProductType, string[]>
        {
            {ProductType.Food, new[]{ "chocolate", "chocolates" }},
            {ProductType.Medical, new[]{ "pills" }},
            {ProductType.Book, new[]{ "book" }}
        };

        public decimal ShelfPrice { get; set; }
        public string Name { get; set; }
        public bool IsImported { get { return Name.Contains("imported "); } }

        public bool IsTypeOf(ProductType productType)
        {
            return itemTypeIdentifiers.ContainsKey(productType) &&
                itemTypeIdentifiers[productType].Any(x => Name.Contains(x));
        }

        public override string ToString()
        {
            return string.Format("{0} at {1}", Name, ShelfPrice);
        }
    }
}