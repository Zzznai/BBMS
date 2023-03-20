using BloodBankManagementSystem.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class BloodCompatibilityTests
    {
        [TestMethod]
        public void GetRecipientsByGroup_ValidGroup_ReturnsRecipients()
        {
            // Arrange
            string group = "A+";
            List<string> expectedRecipients = new List<string> { "A+", "A-", "O+", "O-" };

            // Act
            List<string> actualRecipients = BloodCompatibility.GetRecipientsByGroup(group);

            // Assert
            CollectionAssert.AreEqual(expectedRecipients, actualRecipients);
        }

        [TestMethod]
        public void TestBloodCompatibility_GetRecipientsByGroup_InvalidGroup_ThrowsException()
        {
            // Arrange
            string group = "INVALID_GROUP";

            // Act & Assert
            Assert.ThrowsException<KeyNotFoundException>(() => BloodCompatibility.GetRecipientsByGroup(group));
        }
    }
}
