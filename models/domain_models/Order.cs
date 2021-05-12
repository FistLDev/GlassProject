using System.ComponentModel.DataAnnotations;
using GlassProject.models.domain_models.Enums;

namespace GlassProject.models.domain_models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        
        public User User { get; set; }
        
        public string ProductType { get; set; }
        
    }
}