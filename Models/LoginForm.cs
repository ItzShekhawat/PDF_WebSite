using System.ComponentModel.DataAnnotations;

namespace PDF_Portal_Azure_AD.Models
{
    public class LoginForm
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name length can't be then 20", MinimumLength = 2)]
        public string Username { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public string Password { get; set; }
    }
}
