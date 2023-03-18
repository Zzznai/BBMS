using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Controllers
{
    public class DonorsService
    {
        public List<object> GetAllDonors()
        {
            using (var context = new BloodBankDbContext())
            {
                var donors = context.Donors.Select(d => new
                {
                    Id = d.DonorID,
                    FirstName = d.DonorFirstName,
                    LastName = d.DonorLastName,
                    Gender = d.DonorGender,
                    Age = d.DonorAge,
                    d.BloodGroup,
                    LastDonationDate = d.LastDonationDate == null ? "-" : d.LastDonationDate.ToString(),
                    d.ContactNumber,
                    d.Address
                })
                              .ToList();

                return donors.Cast<object>().ToList();
            }
        }
        public int GetDonorsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.Donors.Count();
            }
        }


    }
}
