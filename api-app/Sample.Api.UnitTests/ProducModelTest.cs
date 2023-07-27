using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.Api.Models;

namespace Sample.Api.Tests.Models
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductProperties_SetAndGetCorrectly()
        {
            // Arrange
            var product = new Product
            {
                Id = 1,
                Name = "Product 1",
                Description = "This is product 1",
                Category = "Category 1",
                Price = 9.99m
            };

            // Act
            var id = product.Id;
            var name = product.Name;
            var description = product.Description;
            var category = product.Category;
            var price = product.Price;

            // Assert
            Assert.AreEqual(1, id);
            Assert.AreEqual("Product 1", name);
            Assert.AreEqual("This is product 1", description);
            Assert.AreEqual("Category 1", category);
            Assert.AreEqual(9.99m, price);
        }
    }
}