using System;
using System.ComponentModel.DataAnnotations;

namespace EducationalNGO.Models
{
    public class Volunteer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Display(Name = "Skills")]
        public string Skills { get; set; }

        [Display(Name = "Availability Status")]
        public string AvailabilityStatus { get; set; }

        [Display(Name = "Join Date")]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }
    }
}