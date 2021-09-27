using System.Collections.Generic;

namespace rehber.Core.DTOs
{
    /// <summary>
    /// Contact Dto'suna, veritabanından gelen ContactInfo alanlarını da Dto olarak almamızı sağlar.
    /// </summary>
    public class ContactWithInfosDto : ContactDto
    {
        public IEnumerable<ContactInfoDto> ContactInfos { get; set;}
    }
}