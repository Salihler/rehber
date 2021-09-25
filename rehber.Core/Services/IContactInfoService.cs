using System.Threading.Tasks;
using rehber.Core.Models;

namespace rehber.Core.Services
{
    public interface IContactInfoService : IService<ContactInfo>
    {
        //Bağlı olduğu tablolara erişmek için kullanacağız. EF Generic service veya repositoryde ilişkili tabloları beraber getirmez.
        Task<ContactInfo> GetWithContactsByIdAsync(int infoId);
    }
}