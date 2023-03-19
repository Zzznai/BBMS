using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public void AddDonation(Donor donor, decimal quantityInLiters)
        {
            try
            {
                using (var context = new BloodBankDbContext())
                {
                    var donation = new BloodDonation
                    {
                        DonorID = donor.DonorID,
                        DonationDate = DateTime.Now,
                        QuantityInLiters = quantityInLiters
                    };

                    if (donor.LastDonationDate != null && donor.LastDonationDate.Value.AddMonths(4) > DateTime.Now)
                    {
                        throw new ArgumentException("You can donate blood after 4 months from your last donation.");
                    }

                    donor.LastDonationDate = donation.DonationDate;
                    context.BloodDonations.Add(donation);
                    context.Donors.AddOrUpdate(donor);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
