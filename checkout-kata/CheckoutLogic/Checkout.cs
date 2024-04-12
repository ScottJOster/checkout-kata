using checkout_kata.Products;
using System.Linq;

namespace checkout_kata.CheckoutLogic
{
    public class Checkout : ICheckout
    {
        public List<Product> Basket { get; set; } = new List<Product>();


        public void Scan(Product product)
        {
            Basket.Add(product);
        }

        public double GetTotalPrice()
        {
            return Basket.Sum(p=>p.PriceGbp);
        }
    }
}
