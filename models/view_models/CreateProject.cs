using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GlassProject.models.view_models
{
    public class CreateProject
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public string Structure { get; set; }
        
        [Required]
        public string Requirements { get; set; }
        
        [Required]
        public string Purpose { get; set; }
        
        public string Type { get; set; }
    }
}