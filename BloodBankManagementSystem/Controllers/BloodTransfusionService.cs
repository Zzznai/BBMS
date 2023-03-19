using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    }
}
