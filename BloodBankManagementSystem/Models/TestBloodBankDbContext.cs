using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Tests
{
    /// <summary>
    /// Represents a custom database context for testing purposes. Inherits from the DbContext class provided by Entity Framework.
    /// Provides properties for several DbSet objects representing database tables in the application, including BloodDonations, BloodStock, BloodTransfusion, Donors, Patients, and Users.
    /// </summary>
    class TestBloodBankDbContext : DbContext
    {
        public TestBloodBankDbContext() : base("BloodBankTestDbContext")
        {
        }

        public DbSet<BloodDonation> BloodDonations { get; set; }
        public DbSet<BloodStock> BloodStock { get; set; }
        public DbSet<BloodTransfusion> BloodTransfusion { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
