using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Controllers
{
    public class BloodTransfusionService
    {
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

        private bool CanUseBlood(decimal neededQuantity, decimal bloodStockQuantity)
        {
            return neededQuantity <= bloodStockQuantity;
        }

        public int GetBloodTransfusionsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.BloodTransfusion.Count();
            }
        }

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
