using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace rehber.Core.Models
{
    /// <summary>
    /// Rehberdeki kişilerin bilgilerinin tutulduğu model
    /// </summary>
    public class Contact : BaseEntity
    {
        public Contact()
        {   // Contact info collection'u null bırakmamak için gerekli.
            ContactInfos = new Collection<ContactInfo>();
        }

        /// <summary>
        /// Kayıtlı kişi ID'si
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Kayıtlı kişi adı
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Kayıtlı kişi soyadı
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Kayıtlı kişinin bağlı olduğu firma
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Kayıtlı kişiye bağlı iletişim bilgileri
        /// </summary>
        public ICollection<ContactInfo> ContactInfos { get; set; }
    }
}