using GlassProject.models.domain_models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GlassProject.repositories.contexts
{
    public class IdentityContext : IdentityDbContext<UserDomainModel>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}