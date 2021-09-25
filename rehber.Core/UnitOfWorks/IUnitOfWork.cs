using System.Threading.Tasks;
using rehber.Core.Repositories;

namespace rehber.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        //TODO:Repository instancelarda Yalnızca Get kullanılabilir.
        IContactRepository Contacts{get; set;}
        IContactInfoRepository ContactInfos { get; set; }
        Task SaveAsync();
        void Save();
    }
}