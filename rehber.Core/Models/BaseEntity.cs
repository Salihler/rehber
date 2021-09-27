using System;

namespace rehber.Core.Models
{
    /// <summary>
    /// Her Entity'de bulunan ortak alanların tutulduğu soyut sınıf.
    /// </summary>
    public abstract class BaseEntity
        {
        /// <summary>
        /// Silinme durumu
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// Oluşturulma tarihi
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Güncellenme tarihi
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}