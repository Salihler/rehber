using System.Threading.Tasks;
using rehber.Core.Models;

namespace rehber.Core.Services
{
    public interface IContactService : IService<Contact>
    {
        /// <summary>
        /// Belirtilen Kişi ID'sine uyan kişi bilgisini, ilişkisi olan iletişim bilgileri ile birlikte getirir. Ef repositorydeki crud işlemlerine, ilişkili tabloları dahil etmediği için kullanılır.
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        Task<Contact> GetWithInfosByIdAsync(int contactId);
    }
}