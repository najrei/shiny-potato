using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using shiny.Controllers;

namespace shiny.Tests.Controllers
{
    [TestClass]
    public class ItemControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            ItemsController controller = new ItemsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Details()
        {
            // Arrange
            ItemsController controller = new ItemsController();

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }



    }
}