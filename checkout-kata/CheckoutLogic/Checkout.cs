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

        public decimal GetTotalPrice()
        {
            var total = Basket.Sum(p=>p.PriceGbp);
            decimal totalDiscount = 0;
            var distinctproducts = Basket.Distinct();
            foreach(var product in distinctproducts) 
            {
                if (product.DiscountApplicableQuantity != null && product.DiscountAmount != null)
                {
                    var totalNumberOfSpecificProduct = Basket.Count(p => p.Name == product.Name);
                    decimal amountOfDiscountsToApply = (decimal)(totalNumberOfSpecificProduct / product.DiscountApplicableQuantity);
                    totalDiscount += amountOfDiscountsToApply * product.DiscountAmount;
                }
            }
            return total - totalDiscount;
        }
    }
}
