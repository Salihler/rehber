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
        
        // DbSet'ler Veritabanımızda bulunan tablolara erişmek için kullanılır.
        public DbSet<Contact> Contacts {get; set;}
        public DbSet<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// Oluşturduğumuz konfigürasyon dosyalarımızı, tablolar ilk oluştuğunda çalıştırmak için kullanılır.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ContactInfoConfiguration());
        }
    }
}