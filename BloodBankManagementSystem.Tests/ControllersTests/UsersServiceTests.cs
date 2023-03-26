using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;

namespace BloodBankManagementSystem.Tests.ControllersTests
{
    [TestClass]
    public class UsersServiceTests
    {
        [TestMethod]
        public void TestGetUserById_ReturnsUserIfExists()
        {
            // Arrange
            var service = new UsersService();
            var expectedUser = new Users { UserID = 3, FirstName = "Kristina", LastName = "Ivanova", Email = "kr.iv@example.com", Password = "password" };

            // Act
            Users actualUser = service.GetUserById(3);

            // Assert
            Assert.AreEqual(expectedUser.UserID, actualUser.UserID);
            Assert.AreEqual(expectedUser.FirstName, actualUser.FirstName);
            Assert.AreEqual(expectedUser.LastName, actualUser.LastName);
            Assert.AreEqual(expectedUser.Email, actualUser.Email);
            Assert.AreEqual(expectedUser.Password, actualUser.Password);
        }

        [TestMethod]
        public void TestGetUserById_ReturnsNullIfUserDoesNotExist()
        {
            // Arrange
            var service = new UsersService();

            // Act
            Users actualUser = service.GetUserById(-1);

            // Assert
            Assert.IsNull(actualUser);
        }

        [TestMethod]
        public void TestIsUserValid_ReturnsTrueForValidUser()
        {
            // Arrange
            var service = new UsersService();
            var user = new Users { Email = "admin@gmail.com", Password = "password" };

            // Act
            var isValid = service.IsUserValid(user.Email, user.Password);

            // Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod]
        public void TestIsUserValid_ReturnsFalseForNullUser()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var isValid = service.IsUserValid(null,null);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestIsUserValid_ReturnsFalseForEmptyEmail()
        {
            // Arrange
            var service = new UsersService();
            var user = new Users { Email = "", Password = "password" };

            // Act
            var isValid = service.IsUserValid(user.Email,user.Password);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestIsUserValid_ReturnsFalseForEmptyPassword()
        {
            // Arrange
            var service = new UsersService();
            var user = new Users { Email = "admin@gmail.com", Password = "" };

            // Act
            var isValid = service.IsUserValid(user.Email, user.Password);

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void TestIsUserAdmin_ReturnsTrueForAdminUser()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var isAdmin = service.IsUserAdmin("admin@gmail.com", "password");

            // Assert
            Assert.IsTrue(isAdmin);
        }

        [TestMethod]
        public void TestIsUserAdmin_ReturnsFalseForNormalUser()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var isAdmin = service.IsUserAdmin("kr.iv@example.com", "password");

            // Assert
            Assert.IsFalse(isAdmin);
        }

        [TestMethod]
        public void TestIsUserAdmin_ReturnsFalseForNonexistentUser()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var isAdmin = service.IsUserAdmin("nonexistent@example.com", "password");

            // Assert
            Assert.IsFalse(isAdmin);
        }

        [TestMethod]
        public void TestIsUserAdmin_ReturnsFalseForMissingEmail()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var isAdmin = service.IsUserAdmin(null, "password");

            // Assert
            Assert.IsFalse(isAdmin);
        }

        [TestMethod]
        public void TestSearchAllUsers_ReturnsAllUsers_WhenSearchInputIsEmpty()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var result = service.SearchAllUsers("");

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void TestSearchAllUsers_ReturnsMatchingUser_WhenSearchInputIsNumeric()
        {
            // Arrange
            var service = new UsersService();
            string searchInput = "3";

            // Act
            var result = service.SearchAllUsers(searchInput);

            // Assert
            var expected = new
            {
                UserID = 3,
                FirstName = "Kristina",
                LastName = "Ivanova",
                Email = "kr.iv@example.com",
                Password = "password"
            };

            var actual = result.FirstOrDefault(u => u.GetType().GetProperty("UserID").GetValue(u).ToString() == searchInput);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.FirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.LastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.Email, actual.GetType().GetProperty("Email").GetValue(actual));
            Assert.AreEqual(expected.Password, actual.GetType().GetProperty("Password").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllUsers_ReturnsMatchingUser_WhenSearchInputIsFirstName()
        {
            // Arrange
            var service = new UsersService();
            string searchInput = "Ivan";

            // Act
            var result = service.SearchAllUsers(searchInput);

            // Assert
            var expected = new
            {
                UserID = 5,
                FirstName = "Ivan",
                LastName = "Kovachev",
                Email = "test@abv.bg",
                Password = "Testing"
            };

            var expected1 = new
            {
                UserID = 6,
                FirstName = "Ivan",
                LastName = "Arnaudov",
                Email = "ivan@example.com",
                Password = "1234567"
            };

            var actual = result.FirstOrDefault(u => u.GetType().GetProperty("FirstName").GetValue(u).ToString() == searchInput);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.UserID, actual.GetType().GetProperty("UserID").GetValue(actual));
            Assert.AreEqual(expected.LastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.Email, actual.GetType().GetProperty("Email").GetValue(actual));
            Assert.AreEqual(expected.Password, actual.GetType().GetProperty("Password").GetValue(actual));

            var actual1 = result.LastOrDefault(u => u.GetType().GetProperty("FirstName").GetValue(u).ToString() == searchInput);

            Assert.IsNotNull(actual1);
            Assert.AreEqual(expected1.UserID, actual1.GetType().GetProperty("UserID").GetValue(actual1));
            Assert.AreEqual(expected1.LastName, actual1.GetType().GetProperty("LastName").GetValue(actual1));
            Assert.AreEqual(expected1.Email, actual1.GetType().GetProperty("Email").GetValue(actual1));
            Assert.AreEqual(expected1.Password, actual1.GetType().GetProperty("Password").GetValue(actual1));
        }

        [TestMethod]
        public void TestSearchAllUsers_ReturnsMatchingUser_WhenSearchInputIsEmail()
        {
            // Arrange
            var service = new UsersService();
            string searchInput = "kr.iv@example.com";

            // Act
            var result = service.SearchAllUsers(searchInput);

            var expected = new
            {
                UserID = 3,
                FirstName = "Kristina",
                LastName = "Ivanova",
                Email = "kr.iv@example.com",
                Password = "password"
            };

            var actual = result.FirstOrDefault(u => u.GetType().GetProperty("Email").GetValue(u).ToString() == searchInput);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.UserID, actual.GetType().GetProperty("UserID").GetValue(actual));
            Assert.AreEqual(expected.LastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.Email, actual.GetType().GetProperty("Email").GetValue(actual));
            Assert.AreEqual(expected.Password, actual.GetType().GetProperty("Password").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllUsers_ReturnsMatchingUser_WhenSearchInputIsFullName()
        {
            // Arrange
            var service = new UsersService();
            string searchInput = "Ivan Arnaudov";

            // Act
            var result = service.SearchAllUsers(searchInput);

            // Assert
            var expected = new
            {
                UserID = 6,
                FirstName = "Ivan",
                LastName = "Arnaudov",
                Email = "ivan@example.com",
                Password = "1234567"
            };

            var actual = result.FirstOrDefault(u =>
                u.GetType().GetProperty("FirstName").GetValue(u).ToString() == "Ivan" &&
                u.GetType().GetProperty("LastName").GetValue(u).ToString() == "Arnaudov"
            );

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.UserID, actual.GetType().GetProperty("UserID").GetValue(actual));
            Assert.AreEqual(expected.FirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.LastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.Email, actual.GetType().GetProperty("Email").GetValue(actual));
            Assert.AreEqual(expected.Password, actual.GetType().GetProperty("Password").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllUsers_ReturnsEmptyList_WhenNoMatchingUserFound()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var result = service.SearchAllUsers("Non-existent User");

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void TestGetUserNameByEmail_ReturnsFullName_WhenUserExists()
        {
            // Arrange
            var service = new UsersService();
            string email = "test@abv.bg";

            // Act
            var result = service.GetUserNameByEmail(email);

            // Assert
            Assert.AreEqual("Ivan Kovachev", result);
        }

        [TestMethod]
        public void TestGetUserNameByEmail_ReturnsEmptyString_WhenEmailDoesNotExist()
        {
            // Arrange
            var service = new UsersService();
            string nonExistentEmail = "nonexistent@example.com";

            // Act
            var result = service.GetUserNameByEmail(nonExistentEmail);

            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void TestDeleteUser_RemovesUserFromDatabase_WhenUserIdIsValid()
        {
            // Arrange
            var service = new UsersService();
            var user = new Users
            {
                UserID = 7,
                FirstName = "Maria",
                LastName = "Georgieva",
                Email = "maria@example.com",
                Password = "LovePlovdiv"
            };
            int userId = user.UserID;

            // Act
            service.DeleteUser(userId);

            // Assert
            using (var context = new BloodBankDbContext())
            {
                var deletedUser = context.Users.FirstOrDefault(u => u.UserID == userId);
                Assert.IsNull(deletedUser);
            }
        }

        [TestMethod]
        public void TestDeleteUser_DoesNothing_WhenUserIdIsInvalid()
        {
            // Arrange
            var service = new UsersService();

            // Act
            service.DeleteUser(-1);

            // Assert
            using (var context = new BloodBankDbContext())
            {
                var allUsers = context.Users.ToList();
                Assert.AreEqual(4, allUsers.Count);
            }
        }

        [TestMethod]
        public void TestIsEmailUsed_ReturnsTrue_WhenEmailIsUsed()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var result = service.IsEmailUsed("admin@gmail.com");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIsEmailUsed_ReturnsFalse_WhenEmailIsNotUsed()
        {
            // Arrange
            var service = new UsersService();

            // Act
            var result = service.IsEmailUsed("nonexistent@example.com");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestIsEmailUsedByAnotherUser_ReturnsFalse_WhenNoOtherUserHasEmail()
        {
            // Arrange
            var service = new UsersService();
            var expected = new
            {
                UserID = 6,
                FirstName = "Ivan",
                LastName = "Arnaudov",
                Email = "ivan@example.com",
                Password = "1234567"
            };

            // Act
            bool isEmailUsed = service.IsEmailUsedByAnotherUser(expected.UserID, "not_used@example.com");

            // Assert
            Assert.IsFalse(isEmailUsed);
        }

        [TestMethod]
        public void TestIsEmailUsedByAnotherUser_ReturnsFalse_SameUserEmail()
        {
            // Arrange
            var service = new UsersService();
            // Assert
            var expected = new
            {
                UserID = 3,
                FirstName = "Kristina",
                LastName = "Ivanova",
                Email = "kr.iv@example.com",
                Password = "password"
            };

            // Act
            bool isEmailUsed = service.IsEmailUsedByAnotherUser(expected.UserID, "kr.iv@example.com");

            // Assert
            Assert.IsFalse(isEmailUsed);
        }

        [TestMethod]
        public void TestIsEmailUsedByAnotherUser_ReturnsTrue_OtherUserHasThatEmail()
        {
            // Arrange
            var service = new UsersService();
            // Assert
            var expected = new
            {
                UserID = 10,
                FirstName = "Anna",
                LastName = "Kirova",
                Email = ""
            };

            // Act
            bool isEmailUsed = service.IsEmailUsedByAnotherUser(expected.UserID, "admin@gmail.com");

            // Assert
            Assert.IsTrue(isEmailUsed);
        }

        [TestMethod]
        public void TestAddUser_AddsUserToDatabase_WhenValidDataIsProvided()
        {
            // Arrange
            var service = new UsersService();
            string firstName = "John";
            string lastName = "Doe";
            string email = "johndoe@example.com";
            string password = "password";

            // Act
            service.AddUser(firstName, lastName, email, password);

            // Assert
            using (var context = new BloodBankDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email);
                Assert.IsNotNull(user);
                Assert.AreEqual(firstName, user.FirstName);
                Assert.AreEqual(lastName, user.LastName);
                Assert.AreEqual(password, user.Password);
                Assert.AreEqual(GlobalConstants.UserRole, user.Role);
            }
        }

        [TestMethod]
        public void TestAddUser_ThrowsException_WhenInputIsNull()
        {
            // Arrange
            var service = new UsersService();
            string firstName = "Nikol";
            string lastName = "Dobeva";
            string email = "dobeva.n@example.com";
            string password = "Qwerty12";

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => service.AddUser(null, null, null, null));
            Assert.ThrowsException<ArgumentNullException>(() => service.AddUser(null, lastName, email, password));
            Assert.ThrowsException<ArgumentNullException>(() => service.AddUser(firstName, null, email, password));
            Assert.ThrowsException<ArgumentNullException>(() => service.AddUser(firstName, lastName, null, password));
            Assert.ThrowsException<ArgumentNullException>(() => service.AddUser(firstName, lastName, email, null));
        }

        [TestMethod]
        public void TestEditUser_Successful()
        {
            // Arrange
            var service = new UsersService();
            var userId = 10;
            var firstName = "Nako";
            var lastName = "Dill";
            var email = "nako_dill@test.com";
            var password = "Secretpassword";

            // Act
            service.EditUser(userId, firstName, lastName, email, password);
            var updatedUser = service.GetUserById(userId);

            // Assert
            Assert.IsNotNull(updatedUser);
            Assert.AreEqual(firstName, updatedUser.FirstName);
            Assert.AreEqual(lastName, updatedUser.LastName);
            Assert.AreEqual(email, updatedUser.Email);
            Assert.AreEqual(password, updatedUser.Password);
        }

        [TestMethod]
        public void TestEditUser_NullOrEmptyInput()
        {
            // Arrange
            var service = new UsersService();
            var userId = 10;
            string firstName = "Nako";
            string lastName = "Fa";
            string email = "nako_fa@test.com";
            string password = "Qwerty123";

            // Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => service.EditUser(userId, null, lastName, email, password));
            Assert.ThrowsException<ArgumentNullException>(() => service.EditUser(userId, firstName, null, email, password));
            Assert.ThrowsException<ArgumentNullException>(() => service.EditUser(userId, firstName, lastName, null, password));
            Assert.ThrowsException<ArgumentNullException>(() => service.EditUser(userId, firstName, lastName, email, null));
            Assert.ThrowsException<ArgumentNullException>(() => service.EditUser(userId, null, null, null, null));
        }

    }
}
