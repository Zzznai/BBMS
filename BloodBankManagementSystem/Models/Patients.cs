using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BloodBankManagementSystem.Models
{
    public partial class Patients
    {
        public class Patient
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Range(150, int.MaxValue)]
            public int PatientID { get; set; }

            [Required]
            [StringLength(30)]
            public string PatientFirstName { get; set; }

            [Required]
            [StringLength(30)]
            public string PatientLastName { get; set; }

            [Required]
            [StringLength(10)]
            public string PatientGender { get; set; }

            [Required]
            public int PatientAge { get; set; }

            [Required]
            [StringLength(5)]
            public string BloodGroup { get; set; }

            [Required]
            [StringLength(20)]
            public string ContactNumber { get; set; }

            [Required]
            [StringLength(100)]
            public string Address { get; set; }
        }

    }
}
