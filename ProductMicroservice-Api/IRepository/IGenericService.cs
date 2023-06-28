using System.Threading.Tasks;
using System.Collections;
namespace ProductMicroservice_Api.IRepository
{
    public interface IGenericService<T>
    {
         IEnumerable<T> GetAll();
         void FindById(int Id);
         void Insert(T entity);
         Task<T> update(T entity);
         void Delete(T entity);
    }
}