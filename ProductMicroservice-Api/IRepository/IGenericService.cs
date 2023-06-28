using System.Threading.Tasks;
using System.Collections;
namespace ProductMicroservice_Api.IRepository
{
    public interface IGenericService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        T Add(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}