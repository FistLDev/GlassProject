using GlassProject.models.domain_models.Enums;

namespace GlassProject.models.domain_models
{
    public class AppOrder : Order
    {
        public AppTechnology Technology { get; set; }
        public string Purpose { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
    }
}