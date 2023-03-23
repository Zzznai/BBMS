using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class BloodStockServiceTests
    {
        private BloodStockService _service;
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

        [TestMethod]
        public void TestGetBloodStockWithNonExistentBloodGroup()
        {
            // Arrange
            var bloodStockService = new BloodStockService();

            // Act
            var bloodStock = bloodStockService.GetBloodStock("W+");

            // Assert
            Assert.IsNull(bloodStock, "BloodStock object should be null.");
        }

        [TestMethod]
        public void TestGetBloodStockWithNullInput()
        {
            // Arrange
            var bloodStockService = new BloodStockService();

            // Act
            var bloodStock = bloodStockService.GetBloodStock(null);

            // Assert
            Assert.IsNull(bloodStock, "BloodStock object should be null.");
        }

        [TestMethod]
        public void TestGetQuantityByBloodGroup()
        {
            // Arrange
            var service = new BloodStockService();

            // Act
            var quantity = service.GetQuantityByBloodGroup("A+");

            // Assert
            Assert.IsTrue(quantity >= 0);
        }

        [TestMethod]
        public void TestGetQuantityByBloodGroupWithNullInput()
        {
            //Arrange
            var service = new BloodStockService();

            //Act
            var quantity = service.GetQuantityByBloodGroup(null);

            //Assert
            Assert.AreEqual(quantity, 0);
        }

        [TestMethod]
        public void TestGetQuantityByBloodGroupWithIncorrectInput()
        {
            //Arrange
            var service = new BloodStockService();

            //Act
            var quantity = service.GetQuantityByBloodGroup("X-");

            //Assert
            Assert.AreEqual(quantity, 0);
        }


        [TestMethod]
        public void TestGetAllBloodGroupsSortedById()
        {
            // Arrange
            var service = new BloodStockService();

            // Act
            var bloodGroups = service.GetAllBloodGroupsSortedById();

            // Assert
            Assert.IsNotNull(bloodGroups);
            Assert.IsTrue(bloodGroups.Count == 8);
            Assert.AreEqual("O+", bloodGroups[0]);
            Assert.AreEqual("O-", bloodGroups[1]);
            Assert.AreEqual("A+", bloodGroups[2]);
            Assert.AreEqual("A-", bloodGroups[3]);
            Assert.AreEqual("B+", bloodGroups[4]);
            Assert.AreEqual("B-", bloodGroups[5]);
            Assert.AreEqual("AB+", bloodGroups[6]);
            Assert.AreEqual("AB-", bloodGroups[7]);
        }

        [TestMethod]
        public void AddBlood_AddsCorrectAmountOfBloodToStock()
        {
            // Arrange
            var service = new BloodStockService();
            var bloodGroup = "B+";
            var startingQuantity = service.GetQuantityByBloodGroup(bloodGroup);
            var amountToAdd = 0.5m;

            // Act
            service.AddBlood(bloodGroup, amountToAdd);
            var newQuantity = service.GetQuantityByBloodGroup(bloodGroup);

            // Assert
            Assert.AreEqual(startingQuantity + amountToAdd, newQuantity);
        }

        [TestMethod]
        public void AddBlood_NullBloodGroup_ThrowsException()
        {
            // Arrange
            var service = new BloodStockService();
            string bloodGroup = null;
            var quantity = 0.3M;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => service.AddBlood(bloodGroup, quantity));
        }

        [TestMethod]
        public void AddBlood_IncorrectBloodGroup_ThrowsException()
        {
            // Arrange
            var service = new BloodStockService();
            string bloodGroup = "W+";
            var quantity = 0.3M;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => service.AddBlood(bloodGroup, quantity));
        }

        [TestMethod]
        public void AddBlood_IncorrectQuantity_ThrowsException()
        {
            // Arrange
            var service = new BloodStockService();
            string bloodGroup = "B-";
            var quantity = -0.5m;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => service.AddBlood(bloodGroup, quantity));
        }

        [TestMethod]
        public void AddBlood_IncorrectBloodGroup_IncorrectQuantity_ThrowsException()
        {
            // Arrange
            var service = new BloodStockService();
            string bloodGroup = "W+";
            var quantity = -10m;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => service.AddBlood(bloodGroup, quantity));
        }
    }
}
