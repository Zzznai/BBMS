using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            var quantity = service.GetQuantityByBloodGroup("XYZ");

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
        public void AddBlood_AddsNewBloodGroup_WhenGroupDoesNotExist()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<BloodBankDbContext>()
                .UseInMemoryDatabase(databaseName: "Test_BloodBank")
                .Options;
            var dbContext = new TestBloodBankDbContext(options);
            var bloodBank = new BloodStock(dbContext);
            var bloodGroup = "AB+";
            var quantity = 5;

            // Act
            bloodBank.AddBlood(bloodGroup, quantity);

            // Assert
            var bloodStock = dbContext.BloodStock.FirstOrDefault(bs => bs.BloodGroup == bloodGroup);
            Assert.IsNotNull(bloodStock);
            Assert.AreEqual(quantity, bloodStock.QuantityInLiters);
        }
    }
}
