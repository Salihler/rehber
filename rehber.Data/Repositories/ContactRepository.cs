using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rehber.Core.Models;
using rehber.Core.Repositories;

namespace rehber.Data.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        private AppDbContext _context;
        public ContactRepository(AppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<Contact> GetWithInfosByIdAsync(int contactId)
        {
            return await _context.Contacts.Include(x => x.ContactInfos).SingleOrDefaultAsync(x => x.Id == contactId);
        }
    }
}