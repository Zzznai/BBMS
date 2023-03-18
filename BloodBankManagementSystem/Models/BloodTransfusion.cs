using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBankManagementSystem.Models
{
    public partial class BloodTransfusion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransferID { get; set; }

        [Required]
        public int SourceStockID { get; set; }

        [Required]
        public int DestinationPatientID { get; set; }

        [Required]
        public DateTime TransferDate { get; set; }

        [Required]
        [StringLength(5)]
        public string BloodGroup { get; set; }

        [Required]
        public decimal QuantityInLiters { get; set; }

        [ForeignKey("SourceStockID")]
        public virtual BloodStock SourceStock { get; set; }
    }
}
