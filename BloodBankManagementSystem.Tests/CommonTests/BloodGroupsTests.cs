using BloodBankManagementSystem.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BloodBankManagementSystem.Tests
{
    [TestClass]
    public class BloodGroupsTests
    {
        [TestMethod]
        public void TestBloodGroups_GetAllBloodGroups_ReturnsCorrectList()
        {
            // Arrange
            List<string> expectedGroups = new List<string>()
            {    
             "A+",
             "A-",
             "B+",
             "B-",
             "AB+",
             "AB-",
             "O+",
             "O-"
            };

            // Act
            List<string> actualGroups = BloodGroups.GetAllBloodGroups();

            // Assert
            CollectionAssert.AreEqual(expectedGroups, actualGroups);
        }
    }
}
