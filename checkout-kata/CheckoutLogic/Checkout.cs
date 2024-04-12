using checkout_kata.Products;

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
            return 1;
        }
    }
}
