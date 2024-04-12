using checkout_kata.Products;

namespace checkout_kata.CheckoutLogic
{
    public interface ICheckout
    {
        List<Product> Basket { get; set; }

        decimal GetTotalPrice();
        void Scan(Product product);
    }
}