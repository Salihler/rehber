namespace rehber.Core.Models
{
    /// <summary>
    /// Rehberdeki kişilerin iletişim bilgilerinin tutuldğu model.
    /// </summary>
    public class ContactInfo : BaseEntity
    {
        /// <summary>
        /// İletişim bilgisi ID'si
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Kişiye ait telefon numarası
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Kişiye ait E-Posta adresi
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Kişiye ait lokasyon(Şehir) bilgisi
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Kişinin ID'si
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// İletişim bilgisine bağlı kişinin bilgisi
        /// </summary>
        public virtual Contact Contact {get; set;}
    }
}