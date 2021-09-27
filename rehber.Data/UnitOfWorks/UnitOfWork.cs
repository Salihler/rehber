using System;
using System.Threading.Tasks;
using rehber.Core.Repositories;
using rehber.Core.UnitOfWorks;
using rehber.Data.Repositories;

namespace rehber.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private ContactRepository _contactRepository;
        private ContactInfoRepository _infoRepository;
        public IContactRepository Contacts => _contactRepository = _contactRepository?? new ContactRepository(_context);
        public IContactInfoRepository ContactInfos => _infoRepository = _infoRepository?? new ContactInfoRepository(_context);

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.AddTimestamps();
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            _context.AddTimestamps();
            await _context.SaveChangesAsync();
        }
    }
}