using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GlassProject.models.domain_models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string UserId { get; set; }
        
        public User User { get; set; }
        
        public string ProductType { get; set; }
        
        [AllowNull]
        public string Structure { get; set; }
        
        public string Purpose { get; set; }

        [AllowNull]
        public string Technologies { get; set; }
        
        public string Requirements { get; set; }
        
        public string Description { get; set; }
    }
}