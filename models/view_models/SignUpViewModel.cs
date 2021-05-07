using System.ComponentModel.DataAnnotations;

namespace GlassProject.models.view_models
{
    public class SignUpViewModel
    {
        [Required]
        [Display (Name = "Name")]
        public string Name { get; set; }
        
        [Required]
        [Display (Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [Display (Name = "Password")]
        public string Password { get; set; }
        
        [Required]
        [Compare("Password", ErrorMessage = "Passwords are not identical")]
        [DataType(DataType.Password)]
        [Display (Name = "Repeat Password")]
        public string RepeatPassword { get; set; }
    }
}