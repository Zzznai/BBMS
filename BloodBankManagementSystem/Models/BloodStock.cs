using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBankManagementSystem.Models
{
    public partial class BloodStock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BloodStockID { get; set; }

        [Required]
        [StringLength(5)]
        [Index(IsUnique = true)]
        public string BloodGroup { get; set; }

        [Required]
        public decimal QuantityInLiters { get; set; }
    }
}
