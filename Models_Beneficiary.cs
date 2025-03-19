using System;
using System.ComponentModel.DataAnnotations;

namespace EducationalNGO.Models
{
    public class Beneficiary
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Contact Number")]
        [Phone]
        public string ContactNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; }

        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public string Status { get; set; }
    }
}