using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class LoggedUserTests
    {
        [TestMethod]
        public void TestLoggedUser_SetName_RetrievesNameCorrectly()
        {
            // Arrange
            string expectedName = "John Doe";

            // Act
            LoggedUser.Name = expectedName;
            string actualName = LoggedUser.Name;

            // Assert
            Assert.AreEqual(expectedName, actualName);
        }
    }
}
