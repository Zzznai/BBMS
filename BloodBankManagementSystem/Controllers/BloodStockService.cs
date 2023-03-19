using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Controllers
{
    public class BloodStockService
    {
        public BloodStock GetBloodStock(string bloodGroup)
        {
            using (var context = new BloodBankDbContext())
            {
                var bloodStock = context.BloodStock
                    .Where(bs => bs.BloodGroup == bloodGroup)
                    .FirstOrDefault();

                return bloodStock;
            }
        }
        public decimal GetQuantityByBloodGroup(string bloodGroup)
        {
            using (var context = new BloodBankDbContext())
            {
                var bloodStock = context.BloodStock
                    .Where(bs => bs.BloodGroup == bloodGroup)
                    .Select(bs => bs.QuantityInLiters)
                    .FirstOrDefault();

                return bloodStock;
            }
        }
        public List<string> GetAllBloodGroupsSortedById()
        {
            using (var context = new BloodBankDbContext())
            {
                var bloodGroups = context.BloodStock
                    .GroupBy(bs => bs.BloodGroup)
                    .OrderBy(g => g.Min(bs => bs.BloodStockID))
                    .Select(g => g.Key)
                    .ToList();

                return bloodGroups;
            }
        }

        public void AddBlood(string bloodGroup, decimal quantity)
        {
            try
            {
                if (BloodGroups.GetAllBloodGroups().Any(b=>b.Equals(bloodGroup)))
                {
                    using (var context = new BloodBankDbContext())
                    {
                        var bloodStock = context.BloodStock
                            .Where(bs => bs.BloodGroup == bloodGroup)
                            .FirstOrDefault();

                        if (bloodStock == null)
                        {
                            bloodStock = new BloodStock()
                            {
                                BloodGroup = bloodGroup,
                                QuantityInLiters = quantity
                            };

                            context.BloodStock.Add(bloodStock);
                        }
                        else
                        {
                            bloodStock.QuantityInLiters += quantity;
                        }

                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("This blood group doesn't exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
