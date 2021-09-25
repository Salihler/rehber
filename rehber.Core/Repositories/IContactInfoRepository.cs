using System.Threading.Tasks;
using rehber.Core.Models;

namespace rehber.Core.Repositories
{
    public interface IContactInfoRepository : IRepository<ContactInfo>
    {
        Task<ContactInfo> GetWithContactByIdAsync(int infoId);
    }
}