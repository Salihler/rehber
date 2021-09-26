using System.Threading.Tasks;
using rehber.Core.Models;

namespace rehber.Core.Services
{    
    /// <summary>
    /// Repository'de bulunan işlemlere ek olarak, belirli Entitylere özel işlemlerin tutulduğu arayüz sınıfıdır. EF Core, ilişkili tablolardaki ilişkili alanları Repositorydeki işlemlere dahil etmediği için kullanılır.
    /// </summary>
    public interface IContactInfoService : IService<ContactInfo>
    {
        /// <summary>
        /// Belirtilen Kişi ID'sine uyan kişi bilgisini, ilişkisi olan iletişim bilgileri ile birlikte getirir. Ef repositorydeki crud işlemlerine, ilişkili tabloları dahil etmediği için kullanılır.
        /// </summary>
        /// <param name="infoId"></param>
        /// <returns></returns>
        Task<ContactInfo> GetWithContactByIdAsync(int infoId);
    }
}