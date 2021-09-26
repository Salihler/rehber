using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using rehber.Core.Models;
using rehber.Core.Repositories;
using rehber.Core.Services;
using rehber.Core.UnitOfWorks;

namespace rehber.Service.Services
{
    public class ContactService : Service<Contact>, IContactService
    {
        public ContactService(IRepository<Contact> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }

        public async Task<Contact> GetWithInfosByIdAsync(int contactId)
        {
            return await _unitOfWork.Contacts.GetWithInfosByIdAsync(contactId);
        }
    }
}