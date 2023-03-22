using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class BloodStockServiceTests
    {
        private TestBloodBankDbContext _context;
        private BloodStockService _service;

        [TestInitialize]
        public void TestInitialize()
        {
            // Initialize the test database context
            _context = new TestBloodBankDbContext();

            // Seed the test database with some initial data
            _context.BloodStock.Add(new BloodStock { BloodGroup = "A+", QuantityInLiters = 10 });
            _context.BloodStock.Add(new BloodStock { BloodGroup = "B+", QuantityInLiters = 5 });
            _context.BloodStock.Add(new BloodStock { BloodGroup = "O+", QuantityInLiters = 7 });
            _context.BloodStock.Add(new BloodStock { BloodGroup = "AB+", QuantityInLiters = 3 });
            _context.SaveChanges();

            // Initialize the service with the test database context
            _service = new BloodStockService { Context = _context };
        }

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
        public void AddBlood_ShouldCreateNewBloodStockIfItDoesNotExist()
        {
            // Arrange
            var bloodGroup = "A-";
            var quantityToAdd = 4m;
            var expectedQuantity = quantityToAdd;

            // Act
            _service.AddBlood(bloodGroup, quantityToAdd);

            // Assert
            var actualQuantity = _context.BloodStock.Where(bs => bs.BloodGroup == bloodGroup).Select(bs => bs.QuantityInLiters).FirstOrDefault();
            Assert.AreEqual(expectedQuantity, actualQuantity, "The blood quantity was not added correctly");
        }


    }
}
