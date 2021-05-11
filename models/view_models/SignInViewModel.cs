using System.ComponentModel.DataAnnotations;

namespace GlassProject.models.view_models
{
    public class SignInViewModel
    {
        [Required]
        [Display (Name = "Name")]
        public string Name { get; set; }
        
        [Required]
        [Display (Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name = "IsRemember")]
        public bool RememberMe { get; set;}
        
        public string ReturnUrl { get; set; }
    }
}