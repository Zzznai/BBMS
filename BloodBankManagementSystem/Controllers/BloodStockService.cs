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

    }
}
