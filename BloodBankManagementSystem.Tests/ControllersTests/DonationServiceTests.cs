using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BloodBankManagementSystem.Tests.ControllersTests
{
    [TestClass]
    public class DonationServiceTests
    {
        [TestMethod]
        public void GetDonorsCount_ReturnsCorrectCount()
        {
            // Arrange
            var service = new DonationService();

            // Act
            int count = service.GetAllDonationsCount();

            // Assert
            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void SearchAllDonations_ReturnsAllDonations_WhenSearchInputIsEmpty()
        {
            var service = new DonationService();
            // Arrange
            var expectedCount = 1;

            // Act
            var result = service.SearchAllDonations(string.Empty);

            // Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

    }
}
