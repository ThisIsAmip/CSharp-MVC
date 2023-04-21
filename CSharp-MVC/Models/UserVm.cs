using CSharp_MVC.Entity;
using System.ComponentModel.DataAnnotations;

namespace CSharp_MVC.Models
{
    public class UserVm
    {
        [Required(ErrorMessage = "Field must not be empty !")]
        [MinLength(6, ErrorMessage = "Account contains at least 6 characters !")]
        [MaxLength(50, ErrorMessage = "Account must be less than 50 characters")]
        public string Account { get; set; }
        [Required(ErrorMessage = "Field must not be empty !")]
        [MinLength(6, ErrorMessage = "Password contains at least 6 characters !")]
        [MaxLength(50, ErrorMessage = "Password must be less than 50 characters")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Field must not be empty !")]
        public string FullName { get; set; }
    }
}
