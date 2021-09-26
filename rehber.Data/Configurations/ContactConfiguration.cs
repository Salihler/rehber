using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rehber.Core.Models;

namespace rehber.Data.Configurations
{
    /// <summary>
    /// Kişi kayıtları veritabanına kayıt edilirken, dikkate alması gereken önayarların belirtildiği sınıftır.
    /// </summary>
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        /// <summary>
        /// Ön ayaların belirtilmesi için kullanılır.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(40);
            builder.ToTable("Contact");
        }
    }
}