using System;
using System.ComponentModel.DataAnnotations;

namespace Forms.Shared
{
    public class Starship
    {
        [Required]
        [StringLength(30, ErrorMessage = "Identifier too long (30 character limit).")]
        public string Description { get; set; }

        [Range(1, 300, ErrorMessage = "Accommodation invalid (1-300).")]
        public int MaximumAccommodation { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        [Range(typeof(bool), "true", "true",
        ErrorMessage = "This form disallows unapproved ships.")]
        public bool IsValidatedDesign { get; set; }


        [Required]
        public DateTime? ProductionDate { get; set; }
    }
}
