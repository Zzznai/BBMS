using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Controllers;
using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Entity.Validation;
using System.Linq;

namespace BloodBankManagementSystem.Tests.ControllersTests
{
    [TestClass]
    public class DonorsServiceTests
    {
        [TestMethod]
        public void SearchAllDonors_ReturnsAllDonors_WhenSearchInputIsEmpty()
        {
            var service = new DonorsService();
            // Arrange
            var expectedCount = 4;

            // Act
            var result = service.SearchAllDonors(string.Empty);

            // Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void TestGetDonorById_ReturnsCorrectDonor()
        {
            // Arrange
            var service = new DonorsService();
            var expectedDonor = new Donor
            {
                DonorID = 1,
                DonorFirstName = "John",
                DonorLastName = "Doe",
                DonorGender = GlobalConstants.Male,
                DonorBirthDate = new DateTime(1983, 3, 19),
                DonorAge = 40,
                BloodGroup = "A+",
                LastDonationDate = new DateTime(2020, 1, 1),
                ContactNumber = "1234567890",
                Address = "123 Main Street"
            };

            // Act
            var result = service.GetDonorById(1);

            // Assert
            Assert.AreEqual(expectedDonor.DonorID, result.DonorID);
            Assert.AreEqual(expectedDonor.DonorFirstName, result.DonorFirstName);
            Assert.AreEqual(expectedDonor.DonorLastName, result.DonorLastName);
            Assert.AreEqual(expectedDonor.DonorGender, result.DonorGender);
            Assert.AreEqual(expectedDonor.DonorBirthDate, result.DonorBirthDate);
            Assert.AreEqual(expectedDonor.DonorAge, result.DonorAge);
            Assert.AreEqual(expectedDonor.BloodGroup, result.BloodGroup);
            Assert.AreEqual(expectedDonor.LastDonationDate, result.LastDonationDate);
            Assert.AreEqual(expectedDonor.ContactNumber, result.ContactNumber);
            Assert.AreEqual(expectedDonor.Address, result.Address);
        }

        [TestMethod]
        public void TestSearchAllDonors_ReturnsMatchingDonor_WhenSearchInputIsNumeric()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "3";
            var expected = new
            {
                DonorID = 3,
                DonorFirstName = "Fatime",
                DonorLastName = "Ekhar",
                DonorGender = GlobalConstants.Female,
                DonorAge = 18,
                BloodGroup = "AB-",
                ContactNumber = "+0 56748 345",
                Address = "Atlanta Street 34A"
            };

            // Act
            var result = service.SearchAllDonors(3.ToString());

            // Assert

            var actual = result.FirstOrDefault(u => u.GetType().GetProperty("Id").GetValue(u).ToString() == searchInput);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.ContactNumber, actual.GetType().GetProperty("ContactNumber").GetValue(actual));
            Assert.AreEqual(expected.Address, actual.GetType().GetProperty("Address").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllDonors_ReturnsMatchingDonor_WhenSearchInputIsFirstName()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "John";
            var expected = new
            {
                DonorID = 1,
                DonorFirstName = "John",
                DonorLastName = "Doe",
                DonorGender = GlobalConstants.Male,
                DonorAge = 40,
                BloodGroup = "A+",
                ContactNumber = "1234567890",
                Address = "123 Main Street"
            };

            // Act
            var result = service.SearchAllDonors(searchInput);

            // Assert
            var actual = result.FirstOrDefault();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.ContactNumber, actual.GetType().GetProperty("ContactNumber").GetValue(actual));
            Assert.AreEqual(expected.Address, actual.GetType().GetProperty("Address").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllDonors_ReturnsMatchingDonor_WhenSearchInputIsLastName()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "Kim";
            var expected = new
            {
                DonorID = 5,
                DonorFirstName = "Taylor",
                DonorLastName = "Kim",
                DonorGender = GlobalConstants.Male,
                DonorAge = 19,
                BloodGroup = "O+",
                ContactNumber = "83993494",
                Address = "Koreatown, 3A"
            };

            var expected1 = new
            {
                DonorID = 6,
                DonorFirstName = "Eun",
                DonorLastName = "Kim",
                DonorGender = GlobalConstants.Female,
                DonorAge = 35,
                BloodGroup = "B-",
                ContactNumber = "893045555",
                Address = "33 Taylor Street"
            };

            // Act
            var result = service.SearchAllDonors(searchInput);

            // Assert

            var actual = result.FirstOrDefault(u => u.GetType().GetProperty("Id").GetValue(u).ToString() == expected.DonorID.ToString());

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.ContactNumber, actual.GetType().GetProperty("ContactNumber").GetValue(actual));
            Assert.AreEqual(expected.Address, actual.GetType().GetProperty("Address").GetValue(actual));

            var actual1 = result.LastOrDefault(u => u.GetType().GetProperty("Id").GetValue(u).ToString() == expected1.DonorID.ToString());
            Assert.IsNotNull(actual1);
            Assert.AreEqual(expected1.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual1));
            Assert.AreEqual(expected1.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual1));
            Assert.AreEqual(expected1.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual1));
            Assert.AreEqual(expected1.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual1));
            Assert.AreEqual(expected1.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual1));
            Assert.AreEqual(expected1.ContactNumber, actual.GetType().GetProperty("ContactNumber").GetValue(actual1));
            Assert.AreEqual(expected1.Address, actual.GetType().GetProperty("Address").GetValue(actual1));
        }

        [TestMethod]
        public void TestSearchAllDonors_ReturnsMatchingDonor_WhenSearchInputIsBloodGroup()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "A+";
            var expected = new
            {
                DonorID = 1,
                DonorFirstName = "John",
                DonorLastName = "Doe",
                DonorGender = GlobalConstants.Male,
                DonorAge = 40,
                BloodGroup = "A+",
                ContactNumber = "1234567890",
                Address = "123 Main Street"
            };

            // Act
            var result = service.SearchAllDonors(searchInput);

            // Assert
            var actual = result.FirstOrDefault();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.ContactNumber, actual.GetType().GetProperty("ContactNumber").GetValue(actual));
            Assert.AreEqual(expected.Address, actual.GetType().GetProperty("Address").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllDonors_ReturnsMatchingDonor_WhenSearchInputIsFullName()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "Taylor Kim";
            var expected = new
            {
                DonorID = 5,
                DonorFirstName = "Taylor",
                DonorLastName = "Kim",
                DonorGender = GlobalConstants.Male,
                DonorAge = 19,
                BloodGroup = "O+",
                ContactNumber = "83993494",
                Address = "Koreatown, 3A"
            };

            // Act
            var result = service.SearchAllDonors(searchInput);

            // Assert
            var actual = result.FirstOrDefault(u =>
                u.GetType().GetProperty("FirstName").GetValue(u).ToString() == "Taylor" &&
                u.GetType().GetProperty("LastName").GetValue(u).ToString() == "Kim"
            );

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorID, actual.GetType().GetProperty("Id").GetValue(actual));
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.ContactNumber, actual.GetType().GetProperty("ContactNumber").GetValue(actual));
            Assert.AreEqual(expected.Address, actual.GetType().GetProperty("Address").GetValue(actual));
        }

        [TestMethod]
        public void TestGetDonorById_ReturnsNull_WhenDonorIdDoesNotExist()
        {
            // Arrange
            var service = new DonorsService();

            // Act
            var result = service.GetDonorById(-1);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SearchAllDonorsForDonations_ReturnsAllDonors_WhenSearchInputIsEmpty()
        {
            var service = new DonorsService();
            // Arrange
            var expectedCount = 4;

            // Act
            var result = service.SearchAllDonorsForDonation(string.Empty);

            // Assert
            Assert.AreEqual(expectedCount, result.Count);
        }

        [TestMethod]
        public void TestSearchAllDonorsForDonation_ReturnsMatchingDonor_WhenSearchInputIsNumeric()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "3";
            var expected = new
            {
                DonorID = 3,
                DonorFirstName = "Fatime",
                DonorLastName = "Ekhar",
                DonorGender = GlobalConstants.Female,
                DonorAge = 18,
                BloodGroup = "AB-",
                LastDonationTime = "-"
            };

            // Act
            var result = service.SearchAllDonorsForDonation(3.ToString());

            // Assert

            var actual = result.FirstOrDefault(u => u.GetType().GetProperty("Id").GetValue(u).ToString() == searchInput);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.LastDonationTime, actual.GetType().GetProperty("LastDonationDate").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllDonorsForDonation_ReturnsMatchingDonor_WhenSearchInputIsFirstName()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "John";
            var expected = new
            {
                DonorID = 1,
                DonorFirstName = "John",
                DonorLastName = "Doe",
                DonorGender = GlobalConstants.Male,
                DonorAge = 40,
                BloodGroup = "A+",
                LastDonationDate = "Jan  1 2020 12:00AM"
            };

            // Act
            var result = service.SearchAllDonorsForDonation(searchInput);

            // Assert
            var actual = result.FirstOrDefault();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.LastDonationDate, actual.GetType().GetProperty("LastDonationDate").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllDonorsForDonation_ReturnsMatchingDonor_WhenSearchInputIsLastName()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "Doe";
            var expected = new
            {
                DonorID = 1,
                DonorFirstName = "John",
                DonorLastName = "Doe",
                DonorGender = GlobalConstants.Male,
                DonorAge = 40,
                BloodGroup = "A+",
                LastDonationDate = "Jan  1 2020 12:00AM"
            };

            // Act
            var result = service.SearchAllDonorsForDonation(searchInput);

            // Assert
            var actual = result.FirstOrDefault(u => u.GetType().GetProperty("Id").GetValue(u).ToString() == expected.DonorID.ToString());

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.LastDonationDate, actual.GetType().GetProperty("LastDonationDate").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllDonorsForDonation_ReturnsMatchingDonor_WhenSearchInputIsBloodGroup()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "A+";
            var expected = new
            {
                DonorID = 1,
                DonorFirstName = "John",
                DonorLastName = "Doe",
                DonorGender = GlobalConstants.Male,
                DonorAge = 40,
                BloodGroup = "A+",
                LastDonationDate = "Jan  1 2020 12:00AM"
            };

            // Act
            var result = service.SearchAllDonorsForDonation(searchInput);

            // Assert
            var actual = result.FirstOrDefault();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.LastDonationDate, actual.GetType().GetProperty("LastDonationDate").GetValue(actual));
        }

        [TestMethod]
        public void TestSearchAllDonorsForDonation_ReturnsMatchingDonor_WhenSearchInputIsFullName()
        {
            // Arrange
            var service = new DonorsService();
            string searchInput = "Taylor Kim";
            var expected = new
            {
                DonorID = 5,
                DonorFirstName = "Taylor",
                DonorLastName = "Kim",
                DonorGender = GlobalConstants.Male,
                DonorAge = 19,
                BloodGroup = "O+",
                LastDonationDate = "-"
            };

            // Act
            var result = service.SearchAllDonorsForDonation(searchInput);

            // Assert
            var actual = result.FirstOrDefault(u =>
                u.GetType().GetProperty("FirstName").GetValue(u).ToString() == "Taylor" &&
                u.GetType().GetProperty("LastName").GetValue(u).ToString() == "Kim"
            );

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.DonorFirstName, actual.GetType().GetProperty("FirstName").GetValue(actual));
            Assert.AreEqual(expected.DonorLastName, actual.GetType().GetProperty("LastName").GetValue(actual));
            Assert.AreEqual(expected.DonorGender, actual.GetType().GetProperty("Gender").GetValue(actual));
            Assert.AreEqual(expected.DonorAge, actual.GetType().GetProperty("Age").GetValue(actual));
            Assert.AreEqual(expected.BloodGroup, actual.GetType().GetProperty("BloodGroup").GetValue(actual));
            Assert.AreEqual(expected.LastDonationDate, actual.GetType().GetProperty("LastDonationDate").GetValue(actual));
        }

        [TestMethod]
        public void DeleteDonor_DonorHasNoDonationRecord_DeletesDonor()
        {
            // Arrange
            using (var context = new BloodBankDbContext())
            {
                var donor = new Donor
                {
                    DonorID = 8,
                    DonorFirstName = "Melanie",
                    DonorLastName = "Emerald",
                    DonorGender = "Female",
                    DonorBirthDate = new DateTime(2000, 3, 13),
                    DonorAge = 23,
                    BloodGroup = "A+",
                    LastDonationDate = null,
                    ContactNumber = "555-1234",
                    Address = "123 Main St"
                };
                context.Donors.Add(donor);
                context.SaveChanges();
            }

            var service = new DonorsService();

            // Act
            service.DeleteDonor(8);

            // Assert
            using (var context = new BloodBankDbContext())
            {
                var deletedDonor = context.Donors.FirstOrDefault(d => d.DonorID == 8);
                Assert.IsNull(deletedDonor);
            }
        }

        [TestMethod]
        public void DeleteDonor_DonorWhoHasDonated_DoesntDeletesDonor()
        {
            // Arrange
            int donorId = 1;
            using (var context = new BloodBankDbContext())
            {
                var donor = context.Donors.FirstOrDefault(d => d.DonorID == donorId);
                Assert.IsNotNull(donor, $"The donor with ID {donorId} could not be found in the database.");
            }

            var service = new DonorsService();

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => service.DeleteDonor(donorId), "An exception should be thrown when attempting to delete a donor who has donated blood.");
            using (var context = new BloodBankDbContext())
            {
                var deletedDonor = context.Donors.FirstOrDefault(d => d.DonorID == donorId);
                Assert.IsNotNull(deletedDonor, "The donor should not be deleted from the database if they have donated blood.");
            }
        }

        [TestMethod]
        public void TestDeleteDoner_DoesNothing_WhenDonerIdIsInvalid()
        {
            // Arrange
            var service = new DonorsService();

            // Act
            service.DeleteDonor(-1);

            // Assert
            using (var context = new BloodBankDbContext())
            {
                var allDonors = context.Donors.ToList();
                Assert.AreEqual(5, allDonors.Count);
            }
        }

        [TestMethod]
        public void GetDonorsCount_ReturnsCorrectCount()
        {
            // Arrange
            var service = new DonorsService();

            // Act
            int count = service.GetDonorsCount();

            // Assert
            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void AddDonor_ValidDonor_AddsDonorToDatabase()
        {
            // Arrange
            var donor = new Donor
            {
                DonorID = 10,
                DonorFirstName = "Karina",
                DonorLastName = "Ying",
                DonorGender = GlobalConstants.Female,
                DonorAge = 30,
                BloodGroup = "A+",
                LastDonationDate = new DateTime(2022, 01, 01),
                ContactNumber = "1234567890",
                Address = "123 West St",
                DonorBirthDate = new DateTime(1992, 01, 01)
            };

            var service = new DonorsService();

            // Act
            service.AddDonor(donor);

            // Assert
            using (var context = new BloodBankDbContext())
            {
                var addedDonor = context.Donors.FirstOrDefault(d => d.DonorID == 10);
                Assert.IsNotNull(addedDonor);
                Assert.AreEqual("Karina", addedDonor.DonorFirstName);
                Assert.AreEqual("Ying", addedDonor.DonorLastName);
                Assert.AreEqual("Female", addedDonor.DonorGender);
                Assert.AreEqual(30, addedDonor.DonorAge);
                Assert.AreEqual("A+", addedDonor.BloodGroup);
                Assert.AreEqual(new DateTime(2022, 01, 01), addedDonor.LastDonationDate);
                Assert.AreEqual("1234567890", addedDonor.ContactNumber);
                Assert.AreEqual("123 West St", addedDonor.Address);
                Assert.AreEqual(new DateTime(1992, 01, 01), addedDonor.DonorBirthDate);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void AddDonor_NullInfo_ThrowsArgumentNullException()
        {
            // Arrange
            var donor = new Donor
            {
                DonorID = 12,
                DonorFirstName = null,
                DonorLastName = "Smith",
                DonorGender = GlobalConstants.Male,
                DonorAge = 25,
                BloodGroup = null,
                LastDonationDate = new DateTime(2022, 02, 01),
                ContactNumber = "555-5678",
                Address = "789 Elm St",
                DonorBirthDate = new DateTime(1997, 01, 01)
            };

            var service = new DonorsService();

            // Act & Assert
            service.AddDonor(donor);
        }

        [TestMethod]
        public void EditDonor_UpdatesExistingDonorRecord()
        {
            // Arrange
            var donor = new Donor
            {
                DonorID = 10,
                DonorFirstName = "Karina",
                DonorLastName = "Jeong",
                DonorGender = GlobalConstants.Female,
                DonorAge = 30,
                BloodGroup = "A+",
                LastDonationDate = new DateTime(2022, 01, 01),
                ContactNumber = "1565-90384",
                Address = "123 West St",
                DonorBirthDate = new DateTime(1992, 01, 01)
            };
            var dbContext = new BloodBankDbContext();
            dbContext.Donors.Add(donor);
            dbContext.SaveChanges();

            var sut = new DonorsService();

            // Act
            donor.DonorLastName = "Jeong";
            donor.ContactNumber = "1565-90384";
            sut.EditDonor(donor);

            // Assert
            var updatedDonor = dbContext.Donors.Find(donor.DonorID);
            Assert.AreEqual("Jeong", updatedDonor.DonorLastName);
            Assert.AreEqual("1565-90384", updatedDonor.ContactNumber);
        }

    }
}
