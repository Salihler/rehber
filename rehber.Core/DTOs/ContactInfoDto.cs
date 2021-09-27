using System.ComponentModel.DataAnnotations;

namespace rehber.Core.DTOs
{
    public class ContactInfoDto
    {
        /// <summary>
        /// Kişiye ait telefon numarası
        /// </summary>
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Phone { get; set; }

        /// <summary>
        /// Kişiye ait E-Posta adresi
        /// </summary>
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Email { get; set; }

        /// <summary>
        /// Kişiye ait lokasyon(Şehir) bilgisi
        /// </summary>
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Location { get; set; }

        /// <summary>
        /// Kişinin ID'si
        /// </summary>
    }
}