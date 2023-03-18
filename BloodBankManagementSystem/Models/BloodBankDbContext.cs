using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using static BloodBankManagementSystem.Models.Patients;
using static BloodBankManagementSystem.Models.Donor;

namespace BloodBankManagementSystem.Models
{
    public class BloodBankDbContext : DbContext
    {
        public BloodBankDbContext()
            : base("name=BloodBankDbContext")
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
