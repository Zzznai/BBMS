using System.Collections.Generic;
using System.Linq;

namespace BloodBankManagementSystem.Common
{
    /// <summary>
    /// Provides blood group compatibility information.
    /// </summary>
    public class BloodCompatibility
    {
        /// <summary>
        /// A dictionary that maps blood groups to a list of compatible blood groups.
        /// </summary>
        public static Dictionary<string, List<string>> RecipientGroups = new Dictionary<string, List<string>>
        {
            { "A+", new List<string> { "A+", "A-", "O+", "O-" } },
            { "A-", new List<string> { "A-", "O-" } },
            { "B+", new List<string> { "B+", "B-", "O+", "O-" } },
            { "B-", new List<string> { "B-", "O-" } },
            { "AB+", new List<string> { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" } },
            { "AB-", new List<string> { "A-", "B-", "AB-", "O-" } },
            { "O+", new List<string> { "O+", "O-" } },
            { "O-", new List<string> { "O-" } }
        };

        public static List<string> GetRecipientsByGroup(string group)
        {
            return RecipientGroups[group].ToList();
        }
    }   
}
