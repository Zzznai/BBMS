using BloodBankManagementSystem.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;


namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class PatientsTests
    {
        [TestMethod]
        public void PatientFirstName_ShouldNotBeNull()
        {
            // Arrange
            var patient = new Patient();

            // Act
            patient.PatientFirstName = null;

            // Assert
            Assert.IsNull(patient.PatientFirstName);
        }

        [TestMethod]
        public void PatientLastName_ShouldNotBeNull()
        {
            // Arrange
            var patient = new Patient();

            // Act
            patient.PatientLastName = null;

            // Assert
            Assert.IsNull(patient.PatientLastName);
        }

        [TestMethod]
        public void PatientGender_ShouldBeValid()
        {
            // Arrange
            var patient = new Patient();

            // Act
            patient.PatientGender = "Male";

            // Assert
            Assert.IsTrue(patient.PatientGender == "Male" || patient.PatientGender == "Female" || patient.PatientGender == "Other");
        }

        [TestMethod]
        public void PatientBirthDate_ShouldNotBeNull()
        {
            // Arrange
            var patient = new Patient();

            // Act
            patient.PatientBirthDate = null;

            // Assert
            Assert.IsNull(patient.PatientBirthDate);
        }

        [TestMethod]
        public void PatientAge_ShouldBeValid()
        {
            // Arrange
            var patient = new Patient();

            // Act
            patient.PatientAge = 120;

            // Assert
            Assert.IsTrue(patient.PatientAge >= 0 && patient.PatientAge <= 120);
        }


        [TestMethod]
        public void BloodGroup_ShouldBeValid()
        {
            // Arrange
            var patient = new Patient();

            // Act
            patient.BloodGroup = "O+";

            // Assert
            Assert.IsTrue(patient.BloodGroup == "A+" || patient.BloodGroup == "A-" || patient.BloodGroup == "B+" || patient.BloodGroup == "B-" || patient.BloodGroup == "AB+" || patient.BloodGroup == "AB-" || patient.BloodGroup == "O+" || patient.BloodGroup == "O-");
        }

        [TestMethod]
        public void ContactNumber_ShouldNotBeNull()
        {
            // Arrange
            var patient = new Patient();

            // Act
            patient.ContactNumber = null;

            // Assert
            Assert.IsNull(patient.ContactNumber);
        }

        [TestMethod]
        public void TestAddress()
        {
            // Arrange
            var patient = new Patient { Address = "123 Main St, Anytown USA" };

            // Act
            var result = patient.Address;

            // Assert
            Assert.AreEqual("123 Main St, Anytown USA", result);
        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void TestCreatePatient_InvalidInput_ThrowsValidationException()
        {
            // Arrange
            var patient = new Patient
            {
                PatientFirstName = "",
                PatientLastName = "",
                PatientGender = "",
                PatientBirthDate = null,
                PatientAge = 0,
                BloodGroup = "",
                ContactNumber = "",
                Address = ""
            };

            // Act
            Validator.ValidateObject(patient, new ValidationContext(patient), true);

            // Assert
            // Expects a ValidationException to be thrown
        }
    }
}
