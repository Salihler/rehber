using Microsoft.EntityFrameworkCore;
using rehber.Core.Models;

namespace rehber.Data
{
    public class AppDbContext : DbContext
    {
        protected AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
        }
        
        public DbSet<Contact> Contacts {get; set;}
        public DbSet<ContactInfo> ContactInfos { get; set; }
    }
}