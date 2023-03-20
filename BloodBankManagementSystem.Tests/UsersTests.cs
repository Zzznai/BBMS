using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;

namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class UsersTests
    {
        [TestMethod]
        public void CreateUser_ValidInput_ReturnsUserWithValidProperties()
        {
            // Arrange
            Users user = new Users()
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@example.com",
                Password = "password",
                Role = GlobalConstants.AdminRole
            };

            // Act

            // Assert
            Assert.AreEqual(0, user.UserID); // default value for int is 0
            Assert.AreEqual("John", user.FirstName);
            Assert.AreEqual("Doe", user.LastName);
            Assert.AreEqual("johndoe@example.com", user.Email);
            Assert.AreEqual("password", user.Password);
            Assert.AreEqual(GlobalConstants.AdminRole, user.Role);
        }
        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void CreateUser_MissingRequiredElement_ThrowsValidationException()
        {
            // Arrange
            Users user = new Users()
            {
                FirstName = "John",
                LastName = "Doe",
                Password = "password",
                Role = GlobalConstants.UserRole
            };

            // Act
            Validator.ValidateObject(user, new ValidationContext(user), true);

            // Assert
            // Expects a ValidationException to be thrown
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void CreateUser_InvalidInput_ThrowsValidationException()
        {
            // Arrange
            Users user = new Users()
            {
                FirstName = "",
                LastName = "",
                Email = "",
                Password = "",
                Role = ""
            };

            // Act
            Validator.ValidateObject(user, new ValidationContext(user), true);

            // Assert
            // Expects a ValidationException to be thrown
        }
    }
}
