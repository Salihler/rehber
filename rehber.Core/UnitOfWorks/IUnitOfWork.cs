using System.Threading.Tasks;
using rehber.Core.Repositories;

namespace rehber.Core.UnitOfWorks
{
    /// <summary>
    /// Database ile ilgili işlemleri önbellekte tutarak, biz belirttiğimizde işleme alması için kullanılır.
    /// </summary>
    public interface IUnitOfWork
    {

        /// <summary>
        /// İlişkili alanlarda işlem yapması için, servis tarafında kullanılır. 
        /// </summary>
        IContactRepository Contacts{get;}

        /// <summary>
        /// İlişkili alanlarda işlem yapması için, servis tarafında kullanılır. 
        /// </summary>
        IContactInfoRepository ContactInfos { get;}

        /// <summary>
        /// Bellekte tutulan işlemleri, istenildiğinde asenkron olarak veritabanına iletmek için kullanılır.
        /// </summary>
        Task SaveAsync();

        /// <summary>
        /// Bellekte tutulan işlemleri, istenildiğinde veritabanına iletmek için kullanılır.
        /// </summary>
        void Save();
    }
}