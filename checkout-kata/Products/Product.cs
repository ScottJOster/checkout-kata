namespace checkout_kata.Products
{
    public class Product
    {
        public string Name { get; set; } = "MiscGoods";
        public double PriceGbp { get; set; }
        public int? DiscountApplicableQuantity { get; set; }
        public double? DiscountAmount {  get; set; }
    }
}
