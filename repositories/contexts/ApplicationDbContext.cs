using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using GlassProject.models.domain_models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GlassProject.repositories.contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        
    }
}