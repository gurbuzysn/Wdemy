using System.ComponentModel.DataAnnotations;

namespace Wdemy.Mvc.Models
{
    public class LoginVM
    {
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;


    }
}
