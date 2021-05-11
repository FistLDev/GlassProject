using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using GlassProject.models.domain_models.Enums;

namespace GlassProject.models.domain_models
{
    public class SiteOrder : Order
    {
        [AllowNull]
        public string Structure { get; set; }
        
        public string Purpose { get; set; }
        
        public List<SiteTechnology> Technologies { get; set; }
        
        public string Requirements { get; set; }
        
        public SiteType SiteType { get; set; }
        public string Description { get; set; }
    }
}