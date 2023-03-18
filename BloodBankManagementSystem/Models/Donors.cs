using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBankManagementSystem.Models
{
    public class Donor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DonorID { get; set; }

        [Required]
        [StringLength(50)]
        public string DonorFirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string DonorLastName { get; set; }

        [Required]
        [StringLength(10)]
        public string DonorGender { get; set; }

        [Required]
        public DateTime? DonorBirthDate { get; set; }

        [Required]
        public int DonorAge { get; set; }

        [Required]
        [StringLength(5)]
        public string BloodGroup { get; set; }

        public DateTime? LastDonationDate { get; set; }

        [Required]
        [StringLength(20)]
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }
    }
}
