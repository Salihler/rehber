using System.Collections.Generic;

namespace rehber.Core.DTOs
{
    /// <summary>
    /// Contact Info Dto'suna, veritabanından gelen Contact alanlarını da Dto olarak almamızı sağlar.
    /// </summary>
    public class InfosWithContactDto : ContactInfoDto
    {
        public IEnumerable<ContactDto> Contacts { get; set; }
    }
}