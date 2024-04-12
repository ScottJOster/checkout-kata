using checkout_kata.CheckoutLogic;
using checkout_kata.Constants;
using checkout_kata.Products;
using FluentAssertions;

namespace UnitTests
{
    [TestClass]
    public class CheckoutTests
    {
        private ProductDictionary ProductDictionary;
        [TestInitialize]

        public void TestInitialize()
        {
            ProductDictionary = new ProductDictionary();

        }
        [TestMethod]
        public void Add_WhenCalledWithValidProduct_AddsProductToBasket()
        {
            //Arrange 
            var productA = ProductDictionary.Products["A"];
            var checkout = new Checkout();
            //Act 
            checkout.Scan(productA);
            //Assert 
            checkout.Basket.Should().NotBeEmpty();
            checkout.Basket.Count.Should().Be(1);
            checkout.Basket[0].Name.Should().Be("Product A");
        }

        [TestMethod]
        public void GetTotalPrice_ShouldReturnTotalPriceOfItemsInBasket()
        {
            //Arrange 
            var productA = ProductDictionary.Products[ProductConstants.ProductA];
            var checkout = new Checkout();
            checkout.Scan(productA);
            //Act 
            var result = checkout.GetTotalPrice();
            //Assert 
            result.Should().Be(50);
           
        }

        [TestMethod]
        public void GetTotalPrice_WhenBasketIsEmptyShouldReturnZero()
        {
            //Arrange 
            var checkout = new Checkout();
            //Act 
            var result = checkout.GetTotalPrice();
            //Assert 
            result.Should().Be(0);

        }
    }
}