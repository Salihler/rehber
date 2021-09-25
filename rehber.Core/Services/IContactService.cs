using System.Threading.Tasks;
using rehber.Core.Models;

namespace rehber.Core.Services
{
    public interface IContactService : IService<Contact>
    {
        //Bağlı olduğu tablolara erişmek için kullanacağız. EF Generic service veya repositoryde ilişkili tabloları beraber getirmez.
        Task<Contact> GetWithInfosByIdAsync(int contactId);
    }
}