using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using rehber.Core.Models;
using rehber.Data.Configurations;
using rehber.Data.Seeds;

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
            modelBuilder.ApplyConfiguration(new ContactSeeds(Enumerable.Range(1, 23).ToArray()));
            modelBuilder.ApplyConfiguration(new ContactInfoSeeds(Enumerable.Range(1, 23).ToArray()));
        }

        public void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.Now;

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = now;
                }
                else
                {
                    ((BaseEntity)entity.Entity).UpdatedAt = now;
                }
            }
        }
    }
}