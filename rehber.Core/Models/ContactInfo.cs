namespace rehber.Core.Models
{
    public class ContactInfo : BaseEntity
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact {get; set;}
    }
}