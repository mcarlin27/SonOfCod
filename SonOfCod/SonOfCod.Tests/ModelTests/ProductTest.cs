using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class ItemTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var product = new Product();
            product.Name = "Alaska Pollock";

            //Act
            var result = product.Name;

            //Assert
            Assert.Equal("Alaska Pollock", result);
        }
        [Fact]
        public void GetScientificNameTest()
        {
            //Arrange
            var product = new Product();
            product.ScientificName = "Theragra chalcogramma";

            //Act
            var result = product.ScientificName;

            //Assert
            Assert.Equal("Theragra chalcogramma", result);
        }
        [Fact]
        public void GetMarketNameTest()
        {
            //Arrange
            var product = new Product();
            product.MarketName = " Pollock";

            //Act
            var result = product.MarketName;

            //Assert
            Assert.Equal(" Pollock", result);
        }
        [Fact]
        public void GetPrimarySourceTest()
        {
            //Arrange
            var product = new Product();
            product.PrimarySource = "Alaska";

            //Act
            var result = product.PrimarySource;

            //Assert
            Assert.Equal("Alaska", result);
        }
        [Fact]
        public void GetSeasonTest()
        {
            //Arrange
            var product = new Product();
            product.Season = "Jan-Feb, Aug-Oct";

            //Act
            var result = product.Season;

            //Assert
            Assert.Equal("Jan-Feb, Aug-Oct", result);
        }
        [Fact]
        public void GetFishingMethodTest()
        {
            //Arrange
            var product = new Product();
            product.FishingMethod = "Trawl";

            //Act
            var result = product.FishingMethod;

            //Assert
            Assert.Equal("Trawl", result);
        }
        [Fact]
        public void GetMaxSizeTest()
        {
            //Arrange
            var product = new Product();
            product.MaxSize = 15;

            //Act
            var result = product.MaxSize;

            //Assert
            Assert.Equal(15, result);
        }
        [Fact]
        public void GetAverageSizeTest()
        {
            //Arrange
            var product = new Product();
            product.AverageSize = 2;

            //Act
            var result = product.AverageSize;

            //Assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void GetSummaryTest()
        {
            //Arrange
            var product = new Product();
            product.Summary = "A white fish";

            //Act
            var result = product.Summary;

            //Assert
            Assert.Equal("A white fish", result);
        }
        [Fact]
        public void GetProductFormFreshTest()
        {
            //Arrange
            var product = new Product();
            product.ProductFormFresh = "skinless, boneless fillets";

            //Act
            var result = product.ProductFormFresh;

            //Assert
            Assert.Equal("skinless, boneless fillets", result);
        }
        [Fact]
        public void GetProductFormFrozenTest()
        {
            //Arrange
            var product = new Product();
            product.ProductFormFrozen = "skinless, boneless fillets";

            //Act
            var result = product.ProductFormFrozen;

            //Assert
            Assert.Equal("skinless, boneless fillets", result);
        }
        [Fact]
        public void GetStorageHandlingTest()
        {
            //Arrange
            var product = new Product();
            product.StorageHandling = "Frozen fillets held at -5 to -15°F will last a year. Fresh fillets held in ice at 32°F will last seven days.";

            //Act
            var result = product.StorageHandling;

            //Assert
            Assert.Equal("Frozen fillets held at -5 to -15°F will last a year. Fresh fillets held in ice at 32°F will last seven days.", result);
        }
        [Fact]
        public void GetCookingSuggestionTest()
        {
            //Arrange
            var product = new Product();
            product.CookingSuggestion = "A lean, versatile fish, Alaska pollock is well-suited for poaching, baking, steaming, sautéing, or deep-frying. As a result, it can be served simply at a fish and chips shop or with a delicate sauce in a white tablecloth restaurant.";

            //Act
            var result = product.CookingSuggestion;

            //Assert
            Assert.Equal("A lean, versatile fish, Alaska pollock is well-suited for poaching, baking, steaming, sautéing, or deep-frying. As a result, it can be served simply at a fish and chips shop or with a delicate sauce in a white tablecloth restaurant.", result);
        }
        [Fact]
        public void GetSellingPointsTest()
        {
            //Arrange
            var product = new Product();
            product.SellingPoints = "Very versatile, low-priced fish. Excellent in everything from fish n’ chips to fish tacos.";

            //Act
            var result = product.SellingPoints;

            //Assert
            Assert.Equal("Very versatile, low-priced fish. Excellent in everything from fish n’ chips to fish tacos.", result);
        }
        [Fact]
        public void GetDefectsTest()
        {
            //Arrange
            var product = new Product();
            product.Defects = "Fillets with gray flesh color, skin specks, bones and parasites.";

            //Act
            var result = product.Defects;

            //Assert
            Assert.Equal("Fillets with gray flesh color, skin specks, bones and parasites.", result);
        }
        [Fact]
        public void GetCostTest()
        {
            //Arrange
            var product = new Product();
            product.Cost = 15;

            //Act
            var result = product.Cost;

            //Assert
            Assert.Equal(15, result);
        }
    }
}