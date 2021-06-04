using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace GlassProject.models.domain_models
{
    public class Order
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string UserId { get; set; }

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