using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Controllers
{
    public class BloodTransfusionService
    {
        public int GetBloodTransfusionsCount()
        {
            using (var context = new BloodBankDbContext())
            {
                return context.BloodTransfusion.Count();
            }
        }
    }
}
