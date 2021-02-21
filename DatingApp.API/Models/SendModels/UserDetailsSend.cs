using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models.SendModels
{
    public class UserDetailsSend
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Username")]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9]{3,11}$", ErrorMessage = "Enter a valid Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Date of Birth")]
        public int Age { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime LastActive { get; set; }
        public string AliasName { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        [Required(ErrorMessage = "Enter MobileNo.")]
        [DataType(DataType.PhoneNumber)]
        public string MobileNo { get; set; }

        public string PhotoUrl { get; set; }
        public ICollection<PhotoDetailSend> Photos { get; set; }
    }
}
