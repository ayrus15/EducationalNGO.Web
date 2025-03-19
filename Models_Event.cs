using System;
using System.ComponentModel.DataAnnotations;

namespace EducationalNGO.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(200)]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Event Date")]
        [DataType(DataType.DateTime)]
        public DateTime EventDate { get; set; }

        [Required]
        public string Location { get; set; }

        [Display(Name = "Maximum Participants")]
        [Range(1, 1000)]
        public int MaxParticipants { get; set; }

        public string Status { get; set; }
    }
}