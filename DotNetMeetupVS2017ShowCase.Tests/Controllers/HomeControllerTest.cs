//TODO remove unused reference
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNetMeetupVS2017ShowCase;
using DotNetMeetupVS2017ShowCase.Controllers;
using DotNetMeetupVS2017ShowCase.Models;

namespace DotNetMeetupVS2017ShowCase.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_Called_ReturnsResult()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index_Called_HasCorrectMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Welcome!", ((MessageDto)result.Model).Message);
        }

        [TestMethod]
        public void About_Called_HasCorrectMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
            //Assert.AreEqual("Your application description page.", ((MessageDto)result.Model).Message);
            
        }

        [TestMethod]
        public void Contact_Called_ReturnsResult()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact_Called_HasCorrectMessage()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;
            
            //TODO Add Moq
            //Mock

            // Assert
            Assert.AreEqual("Your application description page.", ((MessageDto)result.Model).Message);
        }
    }
}
