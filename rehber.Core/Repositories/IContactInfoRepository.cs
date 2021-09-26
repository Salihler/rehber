using System.Threading.Tasks;
using rehber.Core.Models;

namespace rehber.Core.Repositories
{    
    /// <summary>
    /// Repository'de bulunan işlemlere ek olarak, belirli Entitylere özel işlemlerin tutulduğu arayüz sınıfıdır. EF Core, ilişkili tablolardaki ilişkili alanları Repositorydeki işlemlere dahil etmediği için kullanılır.
    /// </summary>
    public interface IContactInfoRepository : IRepository<ContactInfo>
    {

        /// <summary>
        /// Belirtilen iletişim bilgisi ID'sine uyan iletişim bilgisini, ilişkisi olan kişi kayıtlarıyla birlikte getirmek için kullanılır.
        /// </summary>
        /// <param name="infoId"></param>
        /// <returns></returns>
        Task<ContactInfo> GetWithContactByIdAsync(int infoId);
    }
}