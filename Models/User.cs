using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VetClinic.Models
{
    public class User
    {   
        [Required]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int UserType { get; set; }
        public int? Active { get; set; }

        public List<Pet> Pets { get; set; }
    }
}