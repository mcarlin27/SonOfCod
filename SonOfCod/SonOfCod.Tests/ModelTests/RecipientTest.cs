using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class RecipientTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var recipient = new Recipient();
            recipient.Name = "Darth Vader";

            //Act
            var result = recipient.Name;

            //Assert
            Assert.Equal("Darth Vader", result);
        }
        [Fact]
        public void GetEmailTest()
        {
            //Arrange
            var recipient = new Recipient();
            recipient.Email = "vader@deathstar.edu";

            //Act
            var result = recipient.Email;

            //Assert
            Assert.Equal("vader@deathstar.edu", result);
        }
        [Fact]
        public void GetPhoneTest()
        {
            //Arrange
            var recipient = new Recipient();
            recipient.Phone = "123-867-5309";

            //Act
            var result = recipient.Phone;

            //Assert
            Assert.Equal("123-867-5309", result);
        }
    }
}