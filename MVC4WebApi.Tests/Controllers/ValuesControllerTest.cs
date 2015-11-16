using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC4WebApi.Controllers;
using MVC4WebApi.Models;

namespace MVC4WebApi.Tests.Controllers
{
    [TestClass]
    public class CustomersControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            CustomersController controller = new CustomersController();
          
            // Act
            IEnumerable<Customer> result = controller.GetCustomers();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            Customer result = controller.GetCustomers().FirstOrDefault();

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            controller.PostCustomer(new Customer(995, "boy george"));

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            controller.GetCustomer(5);

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            controller.DeleteCustomer(5);

            // Assert
        }
    }
}
