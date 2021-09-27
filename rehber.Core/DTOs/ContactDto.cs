using System.ComponentModel.DataAnnotations;

namespace rehber.Core.DTOs
{
    public class ContactDto
    {
        /// <summary>
        /// Kayıtlı kişi Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Kayıtlı kişi adı
        /// </summary>
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Name { get; set; }
        
        /// <summary>
        /// Kayıtlı kişi soyadı
        /// </summary>
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Surname { get; set; }

        /// <summary>
        /// Kayıtlı kişinin bağlı olduğu firma
        /// </summary>
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Company { get; set; }
    }
}