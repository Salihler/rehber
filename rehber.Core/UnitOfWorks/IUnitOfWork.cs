using System.Threading.Tasks;
using rehber.Core.Repositories;

namespace rehber.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IContactRepository Contacts{get;}
        IContactInfoRepository ContactInfos { get;}
        Task SaveAsync();
        void Save();
    }
}