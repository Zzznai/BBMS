using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
        public List<object> SearchAllDonors(string searchInput)
        {
            using (var context = new BloodBankDbContext())
            {
                var donorsQuery = context.Donors.AsQueryable();

                if (int.TryParse(searchInput, out int donorId))
                {
                    donorsQuery = donorsQuery.Where(d => d.DonorID == donorId);
                }
                else if (!string.IsNullOrWhiteSpace(searchInput))
                {
                    var searchTerm = searchInput.Split(' ');

                    if (searchTerm.Length == 2)
                    {
                        var firstName = searchTerm[0];
                        var lastName = searchTerm[1];

                        donorsQuery = donorsQuery.Where(d => d.DonorFirstName.Contains(firstName) && d.DonorLastName.Contains(lastName));
                    }
                    else
                    {
                        donorsQuery = donorsQuery.Where(d => d.DonorFirstName.Contains(searchInput) || d.DonorLastName.Contains(searchInput));
                    }
                }

                var donors = donorsQuery.Select(d => new
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


        public List<object> GetAllDonorsForDonation()
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
                    LastDonationDate = d.LastDonationDate == null ? "-" : d.LastDonationDate.ToString()
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

        public void AddDonor(Donor donor)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to add the donor {donor.DonorFirstName} {donor.DonorLastName}?",
                                                  "Confirm Add Donor",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new BloodBankDbContext())
                    {
                        context.Donors.Add(donor);
                        context.SaveChanges();

                        MessageBox.Show("Donor added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding donor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void DeleteUser(int donorId)
        {
            using (var context = new BloodBankDbContext())
            {
                var donor = context.Donors.FirstOrDefault(u => u.DonorID == donorId);
                if (donor != null)
                {
                    context.Donors.Remove(donor);
                    context.SaveChanges();
                }
            }
        }
    }
}
