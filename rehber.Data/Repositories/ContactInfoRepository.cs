using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rehber.Core.Models;
using rehber.Core.Repositories;

namespace rehber.Data.Repositories
{
    public class ContactInfoRepository : Repository<ContactInfo>, IContactInfoRepository
    {
        private readonly AppDbContext _dbContext;
        public ContactInfoRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ContactInfo> GetWithContactByIdAsync(int infoId)
        {
            return await _dbContext.ContactInfos.Include(x => x.Contact).SingleOrDefaultAsync(x => x.Id == infoId);
        }
    }
}