using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearchWebApplication.Controllers;
using PeopleSearchWebApplication.Models;
using System.Web.Mvc;

namespace PeopleSearchWebApplication.Tests
{
    [TestClass]
    public class ControllerTests
    {

        /*
         * This unit test checks to see that a Contact Page (view) is returned
         * when the Contact page menu is clicked.
         */
        [TestMethod]
        public void ReturnsContactView()
        {
            // Arrange
            HomeController controllerUnderTest = new HomeController();

            // Act
            ViewResult result = controllerUnderTest.Contact() as ViewResult;

            // Assert
            Assert.AreEqual("Contact", result.ViewName);
        }

        /*
       * This unit test checks to see that an About Page (view) is returned
       * when the About page menu is clicked.
       */
        [TestMethod]
        public void ReturnsAboutView()
        {
            // Arrange
            HomeController controllerUnderTest = new HomeController();

            // Act
            var result = controllerUnderTest.About() as ViewResult;

            // Assert
            Assert.AreEqual("About", result.ViewName);
        }

        /*
        * Assertion fails since a patient list ought to be returned.
        * Red to indicate failure (I expect this test to fail).
        */
        [TestMethod]
        public void ReturnsPersonView()
        {
            // Arrange
            HomeController controllerUnderTest = new HomeController();

            // Act
            var result = controllerUnderTest.Person() as ViewResult;

            // Assert
            Assert.AreEqual("Person", result.ViewName);
        }

        [TestMethod]
        public void TestPersonData()
        {

            // Arrange
            HomeController controllerUnderTest = new HomeController();

            // Act
            var result = controllerUnderTest.Create();

            // Assert
            Assert.AreEqual("Index", (result as RedirectToRouteResult).RouteValues["Person"]);
        }
    }
}
