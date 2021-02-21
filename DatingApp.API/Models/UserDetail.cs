using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Models
{
    public class UserDetail
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Username")]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9]{3,11}$", ErrorMessage = "Enter a valid Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DefaultValue("")]
        [Required(ErrorMessage = "Enter Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Date of Birth")]
        public DateTime DateOfBirth { get; set; } = DateTime.MinValue;

        public DateTime CreateDate { get; set; }
        public DateTime LastActive { get; set; }
        public string AliasName { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }

        [Required(ErrorMessage = "Enter CityName")]
        [DefaultValue("")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter CountryName")]
        [DefaultValue("")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Enter StateName")]
        [DefaultValue("")]
        public string State { get; set; }

        [DefaultValue("")]
        [Required(ErrorMessage = "Enter MobileNo.")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNo { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}