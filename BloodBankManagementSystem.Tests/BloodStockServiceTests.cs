using BloodBankManagementSystem.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class BloodStockServiceTests
    {
        [TestMethod]
        public void TestGetBloodStock()
        {
            // Arrange
            var service = new BloodStockService();

            // Act
            var bloodStock = service.GetBloodStock("A+");

            // Assert
            Assert.IsNotNull(bloodStock);
            Assert.AreEqual("A+", bloodStock.BloodGroup);
            Assert.IsTrue(bloodStock.QuantityInLiters >= 0);
        }

        [TestMethod]
        public void TestGetAllBloodStocks()
        {
            // Arrange
            var service = new BloodStockService();

            // Act
            var bloodStocks = service.GetAllBloodStocks();

            // Assert
            Assert.IsNotNull(bloodStocks);
            Assert.IsTrue(bloodStocks.Count == 8);
            foreach (var bloodStock in bloodStocks)
            {
                Assert.IsNotNull(bloodStock.GetType().GetProperty("BloodGroup").GetValue(bloodStock));
                Assert.IsNotNull(bloodStock.GetType().GetProperty("QuantityInLiters").GetValue(bloodStock));
            }
        }
    }
}
