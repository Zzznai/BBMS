using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Controllers
{
    /// <summary>
    /// Represents a service for managing blood donations in a blood bank.
    /// </summary>
    public class DonationService
    {
        /// <summary>
        /// Retrieves the total count of all blood donations in the database.
        /// </summary>
        /// <returns>The total count of all blood donations.</returns>
        public int GetAllDonationsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.BloodDonations.Count();
            }
        }

        /// <summary>
        /// Retrieves a list of blood donations based on the specified search input. The search can include donor first name, last name, blood group, or a combination of first and last name. If the search input is null or whitespace, all blood donations are returned. The method returns a list of anonymous objects with a subset of the properties of the BloodDonation and Donor entities.
        /// </summary>
        /// <param name="searchInput">The search input to use for filtering the blood donations.</param>
        /// <returns>The method returns a list of anonymous objects with properties including the ID and date of the donation, the first and last name of the donor, their blood group, the quantity donated, and the donor's age.</returns>
        public List<object> SearchAllDonations(string searchInput)
        {
            using (var context = new BloodBankDbContext())
            {
                var donationsQuery = context.BloodDonations.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchInput))
                {
                    var searchTerm = searchInput.Split(' ');

                    if (searchTerm.Length == 2)
                    {
                        var firstName = searchTerm[0];
                        var lastName = searchTerm[1];

                        donationsQuery = donationsQuery.Where(d =>
                            d.Donor.DonorFirstName.Contains(firstName) &&
                            d.Donor.DonorLastName.Contains(lastName));
                    }
                    else
                    {
                        donationsQuery = donationsQuery.Where(d =>
                            (d.Donor.DonorFirstName.Contains(searchInput) ||
                            d.Donor.DonorLastName.Contains(searchInput)) ||
                            d.Donor.BloodGroup.Contains(searchInput));
                    }
                }

                var donations = donationsQuery.Select(d => new
                {
                    Id = d.DonationID,
                    d.DonationDate,
                    DonorFirstName = d.Donor.DonorFirstName,
                    DonorLastName = d.Donor.DonorLastName,
                    d.Donor.BloodGroup,
                    d.QuantityInLiters,
                    d.Donor.DonorAge
                })
                .ToList();

                return donations.Cast<object>().ToList();
            }
        }

        /// <summary>
        /// Adds a blood donation to the database for the specified donor with the given quantity in liters. The method also updates the donor's last donation date to the current date and ensures that the donor is eligible to donate blood based on their last donation date.
        /// </summary>
        /// <param name="donor">The donor for whom the blood donation is being added.</param>
        /// <param name="quantityInLiters">The quantity of blood donated in liters.</param>
        /// <exception cref="ArgumentException">Thrown when the donor has donated blood within the last 4 months and is not eligible to donate again yet.</exception>
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
