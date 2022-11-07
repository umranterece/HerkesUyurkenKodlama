using System.ComponentModel.DataAnnotations;

namespace HerkesUyurkenKodlama.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Username is Required.")]
        [StringLength(30, ErrorMessage ="Username can be max 30 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password is Required")]
        [MinLength(6, ErrorMessage ="Password can be min 6 characters")]
        [MaxLength(16, ErrorMessage = "Password can be max 16 characters")]
        public string Password { get; set; }

    }


    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is Required.")]
        [StringLength(30, ErrorMessage = "Username can be max 30 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(6, ErrorMessage = "Password can be min 6 characters")]
        [MaxLength(16, ErrorMessage = "Password can be max 16 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "RePassword is Required")]
        [MinLength(6, ErrorMessage = "RePassword can be min 6 characters")]
        [MaxLength(16, ErrorMessage = "RePassword can be max 16 characters")]
        [Compare(nameof(Password))]
        public string RePassword { get; set; }

    }
}
