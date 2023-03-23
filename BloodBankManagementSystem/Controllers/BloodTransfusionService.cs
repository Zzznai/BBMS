using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace BloodBankManagementSystem.Controllers
{
    /// <summary>
    /// Represents a service for managing blood transfusions in a blood bank.
    /// </summary>
    public class BloodTransfusionService
    {
        /// <summary>
        /// Adds a new blood transfusion for the specified patient and blood stock.
        /// </summary>
        /// <param name="patient">The patient who will receive the blood transfusion.</param>
        /// <param name="bloodStock">The blood stock from which the blood will be taken.</param>
        /// <param name="quantity">The quantity of blood in liters to be transfused.</param>
        /// <exception cref="ArgumentException">Thrown when there is not enough blood in stock for the requested blood group.</exception>
        public void AddBloodTransfusion(Patient patient, BloodStock bloodStock, decimal quantity)
        {
            using (var context = new BloodBankDbContext())
            {
                bool canUseBlood = CanUseBlood(quantity, bloodStock.QuantityInLiters);

                if (canUseBlood)
                {
                    var bloodTransfusion = new BloodTransfusion()
                    {
                        DestinationPatientID = patient.PatientID,
                        BloodGroup = bloodStock.BloodGroup,
                        QuantityInLiters = quantity,
                        TransferDate = DateTime.Now,
                        BloodStockId = bloodStock.BloodStockID
                    };

                    bloodStock.QuantityInLiters -= quantity;
                    context.BloodStock.AddOrUpdate(bloodStock);
                    context.BloodTransfusion.Add(bloodTransfusion);
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException($"Not enough blood in stock {bloodStock.BloodGroup}!");
                }
            }
        }

        /// <summary>
        /// Determines whether the needed quantity of blood can be taken from the specified blood stock.
        /// </summary>
        /// <param name="neededQuantity">The quantity of blood needed in liters.</param>
        /// <param name="bloodStockQuantity">The quantity of blood available in the blood stock.</param>
        /// <returns><c>true</c> if the needed quantity of blood can be taken from the blood stock; otherwise, <c>false</c>.</returns>
        private bool CanUseBlood(decimal neededQuantity, decimal bloodStockQuantity)
        {
            return neededQuantity <= bloodStockQuantity;
        }

        /// <summary>
        /// Gets the total number of blood transfusions in the database.
        /// </summary>
        /// <returns>The total number of blood transfusions in the database.</returns>
        public int GetBloodTransfusionsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.BloodTransfusion.Count();
            }
        }

        /// <summary>
        /// Retrieves a list of blood transfusions based on the specified search input. The search can include patient first name, last name, blood group, or a combination of first and last name. If the search input is null or whitespace, all blood transfusions are returned. The method returns a list of anonymous objects with a subset of the properties of the BloodTransfusion and Patient entities.
        /// </summary>
        /// <param name="searchInput">The search input to use for filtering the blood transfusions.</param>
        /// <returns>The method returns a list of anonymous objects with properties including the ID and date of the transfusion, the first and last name of the patient, their blood group, the blood group received, the quantity transfused, and the patient's age.</returns>
        public List<object> SearchAllTransfusions(string searchInput)
        {
            using (var context = new BloodBankDbContext())
            {
                var transfusionsQuery = context.BloodTransfusion.AsQueryable();

                if (!string.IsNullOrWhiteSpace(searchInput))
                {
                    var searchTerm = searchInput.Split(' ');

                    if (searchTerm.Length == 2)
                    {
                        var firstName = searchTerm[0];
                        var lastName = searchTerm[1];

                        transfusionsQuery = transfusionsQuery.Where(p =>
                            p.Patient.PatientFirstName.Contains(firstName) &&
                            p.Patient.PatientLastName.Contains(lastName));
                    }
                    else
                    {
                        transfusionsQuery = transfusionsQuery.Where(p =>
                            (p.Patient.PatientFirstName.Contains(searchInput) ||
                            p.Patient.PatientLastName.Contains(searchInput)) ||
                            p.Patient.BloodGroup.Contains(searchInput));
                    }
                }

                var donations = transfusionsQuery.Select(p => new
                {
                    Id = p.TransferID,
                    p.TransferDate,
                    PatientFirstName = p.Patient.PatientFirstName,
                    PatientLastName = p.Patient.PatientLastName,
                    PatientBloodGroup = p.Patient.BloodGroup,
                    ReceivedBloodGroup = p.BloodGroup,
                    p.QuantityInLiters,
                    p.Patient.PatientAge
                })
                .ToList();

                return donations.Cast<object>().ToList();
            }
        }
    }
}
