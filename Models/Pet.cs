using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VetClinic.Models
{
    public class Pet
    {
        [Required]
        public int PetId { get; set; }
        [Required]
        public string PetName { get; set; }
        [Required]
        public int PetType { get; set; }
        public string Breed { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }

        public List<Visit> Visits { get; set; }
    }
}