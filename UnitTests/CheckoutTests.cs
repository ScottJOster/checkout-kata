using checkout_kata.CheckoutLogic;
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
    }
}