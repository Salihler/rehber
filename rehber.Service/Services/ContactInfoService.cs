using System.Threading.Tasks;
using rehber.Core.Models;
using rehber.Core.Repositories;
using rehber.Core.Services;
using rehber.Core.UnitOfWorks;

namespace rehber.Service.Services
{
    public class ContactInfoService : Service<ContactInfo>, IContactInfoService
    {
        public ContactInfoService(IRepository<ContactInfo> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public async Task<ContactInfo> GetWithContactByIdAsync(int infoId)
        {
            return await _unitOfWork.ContactInfos.GetWithContactByIdAsync(infoId);
        }
    }
}