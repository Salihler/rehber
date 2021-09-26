using Microsoft.EntityFrameworkCore;
using rehber.Core.Models;
using rehber.Data.Configurations;

namespace rehber.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }
        
        public DbSet<Contact> Contacts {get; set;}
        public DbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ContactInfoConfiguration());
        }
    }
}