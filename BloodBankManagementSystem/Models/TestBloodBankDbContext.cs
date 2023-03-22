using System.Data.Entity;

namespace BloodBankManagementSystem.Models
{
    public class TestBloodBankDbContext : DbContext
    {
        public TestBloodBankDbContext() : base("TestBloodBankDbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<TestBloodBankDbContext>());
        }
        public DbSet<BloodDonation> BloodDonations { get; set; }
        public DbSet<BloodStock> BloodStock { get; set; }
        public DbSet<BloodTransfusion> BloodTransfusion { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}