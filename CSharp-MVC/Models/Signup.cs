using System.ComponentModel.DataAnnotations;

namespace CSharp_MVC.Models
{
    public class Signup
    {
        [Required(ErrorMessage = "Field must not be empty !")]
        [MinLength(6, ErrorMessage = "Account must contain minimum 6 characters")]
        [MaxLength(50, ErrorMessage = "Account must contain maximum 50 characters")]
        public string Account { get; set; }
        [Required(ErrorMessage = "Field must not be empty")]
        [MinLength(6, ErrorMessage = "Password must contain minimum 6 characters")]
        [MaxLength(50, ErrorMessage = "Password must contain maximum 50 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Field must not be empty")]
        public string FullName { get; set; }
    }
}
