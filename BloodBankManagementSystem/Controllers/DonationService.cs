using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Controllers
{
    public class DonationService
    {
        public int GetAllDonationsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.BloodDonations.Count();
            }
        }
    }
}
