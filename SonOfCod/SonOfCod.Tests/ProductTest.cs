using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class ItemTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var product = new Product();

            //Act
            var result = product.Name;

            //Assert
            Assert.Equal("Alaska Pollock", result);
        }
    }
}