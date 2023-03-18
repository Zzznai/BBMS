using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BloodBankManagementSystem.Models.Donors;

namespace BloodBankManagementSystem.Models
{
    public partial class BloodDonation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DonationID { get; set; }

        [Required]
        public int DonorID { get; set; }

        [Required]
        public DateTime DonationDate { get; set; }

        [Required]
        public decimal QuantityInLiters { get; set; }

        [ForeignKey("DonorID")]
        public virtual Donor Donor { get; set; }
    }
}
