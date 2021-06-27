using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VetClinic.Models
{
    public class Visit
    {
        [Required]
        public int VisitId { get; set; }
        [Required]
        public int VisitType { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime VisitDate { get; set; }
        [Required]
        public string Notes { get; set; }

        [Required]
        public int PetId { get; set; }
        public Pet Pet { get; set; }

    }
}