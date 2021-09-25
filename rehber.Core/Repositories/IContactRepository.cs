using System.Threading.Tasks;
using rehber.Core.Models;

namespace rehber.Core.Repositories
{
    public interface IContactRepository : IRepository<Contact>
    {
        Task<Contact> GetWithInfosByIdAsync(int contactId);
    }
}