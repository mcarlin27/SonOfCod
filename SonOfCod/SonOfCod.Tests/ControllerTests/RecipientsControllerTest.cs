using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class RecipientsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            RecipientsController controller = new RecipientsController();

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
