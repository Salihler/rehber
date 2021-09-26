using System.Threading.Tasks;
using rehber.Core.Models;

namespace rehber.Core.Repositories
{
    public interface IContactRepository : IRepository<Contact>
    {

        /// <summary>
        /// Belirtilen Kişi ID'sine uyan kişi bilgisini, ilişkisi olan iletişim bilgileri ile birlikte getirir.
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        Task<Contact> GetWithInfosByIdAsync(int contactId);
    }
}