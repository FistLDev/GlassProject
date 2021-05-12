using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlassProject.models.domain_models.Enums
{
    public class Technology
    {
        [Key]
        public int Id { get; set; }
        public string TechnologyName { get; set; }
    }
}