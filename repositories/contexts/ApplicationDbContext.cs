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
        private IConfiguration _configuration = new ConfigurationRoot(new List<IConfigurationProvider>());
        private readonly StreamWriter logStream = new StreamWriter(@"D:/Temp/log.txt", true);
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(logStream.WriteLine);
        }
        
        public override void Dispose()
        {
            base.Dispose();
            logStream.Dispose();
        }
 
        public override async ValueTask DisposeAsync()
        {
            await base.DisposeAsync();
            await logStream.DisposeAsync();
        }
    }
}