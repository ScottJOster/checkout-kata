namespace checkout_kata.Products
{
    public class Product
    {
        public string Name { get; set; } = "MiscGoods";
        public decimal PriceGbp { get; set; }
        public int? DiscountApplicableQuantity { get; set; }
        public decimal DiscountAmount { get; set; } = 0;
    }
}
