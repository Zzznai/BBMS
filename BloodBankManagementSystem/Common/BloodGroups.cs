using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Common
{
    public static class BloodGroups
    {
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
