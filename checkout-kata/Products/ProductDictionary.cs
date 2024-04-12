using checkout_kata.Constants;

namespace checkout_kata.Products
{
    public class ProductDictionary
    {
        /// <summary>
        /// Dictionary of products and required fields simulating configurable entities in a DB
        /// in memory db would be better if time was in abudnace 
        /// </summary>
        public IDictionary<string, Product> Products = new Dictionary<string, Product> 
        {
            { ProductConstants.ProductA, new Product{
                Name = ProductConstants.ProductAName, PriceGbp = ProductConstants.ProductAPrice,
                DiscountApplicableQuantity = ProductConstants.ADiscountQty,
                DiscountAmount = ProductConstants.ADiscountAmount} },
            { ProductConstants.ProductB, new Product{
                Name = ProductConstants.ProductBName, PriceGbp = ProductConstants.ProductBPrice,
                DiscountApplicableQuantity = ProductConstants.BDiscountQty,
                DiscountAmount = ProductConstants.BDiscountAmount} },
            { ProductConstants.ProductC, new Product{
                Name = ProductConstants.ProductCName, PriceGbp = ProductConstants.ProductCPrice} },
            { ProductConstants.ProductD, new Product{
                Name = ProductConstants.ProductDName, PriceGbp = ProductConstants.ProductDPrice,
               } }
        };
    }
}
