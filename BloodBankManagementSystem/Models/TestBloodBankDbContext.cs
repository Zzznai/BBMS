using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Models
{
    public class TestBloodBankDbContext : BloodBankDbContext
    {
        /// <summary>
        /// Initializes a new instance of the TestBloodBankDbContext class with a private in-memory data store.
        /// </summary>
        public TestBloodBankDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TestBloodBankDbContext>());
        }
    }
}
