using System;
using System.ComponentModel.DataAnnotations;

namespace EducationalNGO.Models
{
    public class Donation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Donor Name is required")]
        [Display(Name = "Donor Name")]
        [StringLength(100)]
        public string DonorName { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "Donation Type")]
        public string DonationType { get; set; }

        [Display(Name = "Purpose")]
        public string Purpose { get; set; }

        [Display(Name = "Donation Date")]
        [DataType(DataType.Date)]
        public DateTime DonationDate { get; set; }

        [Required]
        [Display(Name = "Payment Method")]
        public string PaymentMethod { get; set; }
    }
}