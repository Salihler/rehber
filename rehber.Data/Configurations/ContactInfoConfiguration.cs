using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rehber.Core.Models;

namespace rehber.Data.Configurations
{
    /// <summary>
    /// İletişim Bilgileri kayıtları veritabanına kayıt edilirken, dikkate alması gereken önayarların belirtildiği sınıftır.
    /// </summary>
    public class ContactInfoConfiguration : IEntityTypeConfiguration<ContactInfo>
    {
        /// <summary>
        /// Ön ayaların belirtilmesi için kullanılır.
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Location).IsRequired().HasMaxLength(50);
            builder.ToTable("ContactInfo");
        }
    }
}