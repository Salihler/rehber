using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using rehber.Core.Models;
using rehber.Core.Services;

namespace rehber.Test
{
    public class ServiceFake : IContactService
    {
        private readonly List<Contact> _contacts;

        public ServiceFake()
        {
            _contacts = new List<Contact>(){
                new Contact{Id = 1, Name = "Eren", Surname = "Salihler", Company = "Meydan Bilişim"},
                new Contact{Id = 2, Name = "İlker", Surname = "Ayrık", Company = "Kısmet Bilişim"},
                new Contact{Id = 3, Name = "Sude Naz", Surname = "Mert", Company = "Etik Teknoloji"}
            };
        }

        public async Task AddAsync(Contact entity)
        {
            entity.Id = 4;
            _contacts.Add(entity);
        }

        public Task AddRangeAsync(IEnumerable<Contact> entities)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Contact>> GetAllAsync()
        {
            return  _contacts;
        }

        public async Task<Contact> GetByIdAsync(int id)
        {
            return _contacts.SingleOrDefault(x => x.Id == id);
        }

        public Task<Contact> GetWithInfosByIdAsync(int contactId)
        {
            throw new NotImplementedException();
        }

        public void Remove(Contact entity)
        {
            var exist = _contacts.First(x => x.Id == entity.Id);
            _contacts.Remove(exist);
        }

        public void RemoveRange(IEnumerable<Contact> entities)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact entity)
        {
            var exist = _contacts.First(x => x.Id == entity.Id);
            exist.Name = entity.Name;
            exist.Surname = entity.Surname;
            exist.Company = entity.Company;
            return exist;

        }

        public Task<IEnumerable<Contact>> Where(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}