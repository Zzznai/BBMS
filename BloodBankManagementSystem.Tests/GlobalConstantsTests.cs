using BloodBankManagementSystem.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class GlobalConstantsTests
    {
        [TestMethod]
        public void AdminRole_ShouldReturnAdmin()
        {
            // Arrange
            string expected = "Admin";

            // Act
            string actual = GlobalConstants.AdminRole;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserRole_ShouldReturnUser()
        {
            // Arrange
            string expected = "User";

            // Act
            string actual = GlobalConstants.UserRole;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Female_ShouldReturnFemale()
        {
            // Arrange
            string expected = "Female";

            // Act
            string actual = GlobalConstants.Female;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Male_ShouldReturnMale()
        {
            // Arrange
            string expected = "Male";

            // Act
            string actual = GlobalConstants.Male;

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
