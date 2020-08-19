using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingApp.API.Models
{
    public class UserLogin
    {

        [Required(ErrorMessage = "Enter Username")]
        [RegularExpression("^[a-zA-Z][a-zA-Z0-9]{3,11}$",ErrorMessage = "Enter a valid Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter Password")]
		[Display(Name = "Password")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

    }
}