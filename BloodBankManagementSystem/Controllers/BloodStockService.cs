using BloodBankManagementSystem.Common;
using BloodBankManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagementSystem.Controllers
{
    /// <summary>
    /// Represents a service for managing blood stocks in a blood bank.
    /// </summary>
    public class BloodStockService
    {
        /// <summary>
        /// Gets the blood stock for a given blood group.
        /// </summary>
        /// <param name="bloodGroup">The blood group to retrieve the stock for.</param>
        /// <returns>The blood stock for the given blood group.</returns>
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

        /// <summary>
        /// Gets a list of all blood stocks in the blood bank.
        /// </summary>
        /// <returns>A list of objects containing the blood group and quantity in liters for each blood stock.</returns>
        public List<object> GetAllBloodStocks()
        {
            using (var context = new BloodBankDbContext())
            {
                var bloodStock = context.BloodStock.Select(bs => new
                {
                    BloodGroup = bs.BloodGroup,
                    QuantityInLiters=bs.QuantityInLiters
                })
                              .ToList();

                return bloodStock.Cast<object>().ToList();
            }
        }

        /// <summary>
        /// Gets the quantity of blood in liters for a given blood group.
        /// </summary>
        /// <param name="bloodGroup">The blood group to retrieve the quantity for.</param>
        /// <returns>The quantity of blood in liters for the given blood group.</returns>
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

        /// <summary>
        /// Gets a list of all blood groups sorted by their minimum BloodStockID.
        /// </summary>
        /// <returns>A list of all blood groups sorted by their minimum BloodStockID.</returns>
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

        /// <summary>
        /// Adds the specified quantity of blood to the blood stock for the given blood group.
        /// </summary>
        /// <param name="bloodGroup">The blood group to add blood for.</param>
        /// <param name="quantity">The quantity of blood to add in liters.</param>
        /// <exception cref="ArgumentException">Thrown if the specified blood group does not exist.</exception>
        public void AddBlood(string bloodGroup, decimal quantity)
        {
            try
            {
                if(quantity<=0)
                {
                    throw new ArgumentException("Quantity must be greater than zero");
                }

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
                    throw new ArgumentException("This blood group doesn't exist");
                }
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
