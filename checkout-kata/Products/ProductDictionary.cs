using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkout_kata.Products
{
    public class ProductDictionary
    {
        /// <summary>
        /// Dictionary of products and required fields simulating configurable entities in a DB
        /// </summary>
        public IDictionary<string, Product> Products = new Dictionary<string, Product> 
        {
            { "A", new Product{Name = "Product A", PriceGbp = 50, DiscountApplicableQuantity = 3, DiscountAmount = 20} },
            { "B", new Product{Name = "Product B", PriceGbp = 30, DiscountApplicableQuantity = 2, DiscountAmount = 15} },
            { "C", new Product{Name = "Product C", PriceGbp = 20} },
            { "D", new Product{Name = "Product D", PriceGbp = 15} }

        };
    }
}
