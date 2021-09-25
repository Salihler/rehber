using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace rehber.Core.Models
{
    public class Contact : BaseEntity
    {
        public Contact()
        {
            ContactInfos = new Collection<ContactInfo>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public ICollection<ContactInfo> ContactInfos { get; set; }
    }
}