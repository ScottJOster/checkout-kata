using checkout_kata.Products;

namespace checkout_kata.CheckoutLogic
{
    public interface ICheckout
    {
        List<Product> Basket { get; set; }

        double GetTotalPrice();
        void Scan(Product product);
    }
}