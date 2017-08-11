﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests
{
    public class ProductsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            ProductsController controller = new ProductsController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ViewResult_Details_Test()
        {
            //Arrange
            ProductsController controller = new ProductsController();

            //Act
            var result = controller.Details(3);

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}