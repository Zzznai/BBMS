using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Common
{
    /// <summary>
    /// This class provides a list of all blood groups that can be used in the blood bank management system.
    /// </summary>
    public static class BloodGroups
    {
        /// <summary>
        /// Returns a list of all the blood groups.
        /// </summary>
        /// <returns>A List of strings representing all the blood groups.</returns>
        /// <remarks>The list includes all eight blood groups.</remarks>
        public static List<string> GetAllBloodGroups()
        {
            return new List<string>()
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
        }
    }
}
