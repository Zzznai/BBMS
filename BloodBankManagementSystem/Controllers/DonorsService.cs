using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BloodBankManagementSystem.Controllers
{
    /// <summary>
    /// Represents a service for managing donors in a blood bank.
    /// </summary>
    public class DonorsService
    {
        /// <summary>
        /// Searches all donors based on a given search input.
        /// If the search input is null or empty, the method will return all donors in the database.
        /// </summary>
        /// <param name="searchInput">The search input to use. Can be a donor ID or a donor's first name, last name, or both.</param>
        /// <returns>A list of anonymous objects representing the matching donors.</returns>
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
                        donorsQuery = donorsQuery.Where(d => d.DonorFirstName.Contains(searchInput) || d.DonorLastName.Contains(searchInput) || d.BloodGroup.Contains(searchInput));
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

        /// <summary>
        /// Gets the donor with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the donor to retrieve.</param>
        /// <returns>The donor with the specified ID, or null if no such donor exists.</returns>
        public Donor GetDonorById(int id)
        {
            using (var context = new BloodBankDbContext())
            {
                var donor = context.Donors.FirstOrDefault(d => d.DonorID == id);
                return donor;
            }
        }

        /// <summary>
        /// Searches all donors for potential blood donations based on a given search input.
        /// If the search input is null or empty, the method will return all donors in the database.
        /// </summary>
        /// <param name="searchInput">The search input to use. Can be a donor ID or a donor's first name, last name, or both.</param>
        /// <returns>A list of anonymous objects representing the matching donors, including their ID, first name, last name, gender, age, blood group, and last donation date.</returns>
        public List<object> SearchAllDonorsForDonation(string searchInput)
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
                        donorsQuery = donorsQuery.Where(d => d.DonorFirstName.Contains(searchInput) || d.DonorLastName.Contains(searchInput) || d.BloodGroup.Contains(searchInput));
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
                })
                .ToList();

                return donors.Cast<object>().ToList();
            }
        }

        /// <summary>
        /// Deletes a donor from the database by their donor ID. If the donor has a donation record, it throws an exception.
        /// </summary>
        /// <param name="DonorId">The donor ID of the donor to be deleted.</param>
        /// <exception cref="ArgumentException">Thrown when attempting to delete a donor that has already donated blood.</exception>
        public void DeleteDonor(int DonorId)
        {
            using (var context = new BloodBankDbContext())
            {
                var donor = context.Donors.FirstOrDefault(d => d.DonorID == DonorId);
                if (donor != null)
                {
                    var donationRecord = context.BloodDonations.FirstOrDefault(dr => dr.DonorID == DonorId);
                    if (donationRecord == null)
                    {
                        context.Donors.Remove(donor);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new ArgumentException($"Cannot delete a donor which already has donated blood in the system!");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the total number of donors currently in the database.
        /// </summary>
        /// <returns>The total number of donors in the database.</returns>
        public int GetDonorsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.Donors.Count();
            }
        }

        /// <summary>
        /// Adds a new donor to the database.
        /// </summary>
        /// <param name="donor">The donor to add.</param>
        public void AddDonor(Donor donor)
        {
            try
            {
                using (var context = new BloodBankDbContext())
                {
                    context.Donors.Add(donor);
                    if (donor != null)
                    {
                        context.SaveChanges();

                        MessageBox.Show("Donor added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new ArgumentNullException("One or more input arguments are null or empty.");
                    }

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error adding donor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates an existing donor record in the database.
        /// </summary>
        /// <param name="donor">The donor object with updated information.</param>
        /// <exception cref="ArgumentException">Thrown if the donor with the specified ID does not exist in the database.</exception>
        /// <exception cref="ArgumentException">Thrown if an error occurs while updating the donor record.</exception>
        public void EditDonor(Donor donor)
        {
            try
            {
                using (var context = new BloodBankDbContext())
                {
                   
                    var existingDonor = context.Donors.FirstOrDefault(d => d.DonorID == donor.DonorID);
                    if (existingDonor != null)
                    {
                        existingDonor.DonorFirstName = donor.DonorFirstName;
                        existingDonor.DonorLastName = donor.DonorLastName;
                        existingDonor.DonorGender = donor.DonorGender;
                        existingDonor.DonorBirthDate = donor.DonorBirthDate;
                        existingDonor.DonorAge = donor.DonorAge;
                        existingDonor.BloodGroup = donor.BloodGroup;
                        existingDonor.LastDonationDate = donor.LastDonationDate;
                        existingDonor.ContactNumber = donor.ContactNumber;
                        existingDonor.Address = donor.Address;

                        context.SaveChanges();
                        MessageBox.Show("Donor updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception($"Donor with ID {donor.DonorID} not found.");
                        MessageBox.Show("Donor not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
                MessageBox.Show("Error editing donor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
