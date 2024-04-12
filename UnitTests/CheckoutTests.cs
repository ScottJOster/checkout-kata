using checkout_kata.Products;
using System.Net.Http.Headers;

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
        public void TestMethod1()
        {
            var productA = ProductDictionary.Products["A"];
            Assert.IsNotNull(productA);
            Assert.AreEqual("Product A", productA.Name);
        }
    }
}