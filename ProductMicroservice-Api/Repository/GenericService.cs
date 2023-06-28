using Microsoft.EntityFrameworkCore;
using ProductMicroservice.DBContexts;
using ProductMicroservice_Api.IRepository;


namespace ProductMicroservice_Api.Repository
{
    public class GenericService<T> : IGenericService<T> where T  : class
    {
        private ProductContext _context = null;
        private DbSet<T> table = null;

        public GenericService()
        {
            this.table = _context.Set<T>();
            this._context = new ProductContext();
        }

        public GenericService(ProductContext _context)
        {
            this.table = _context.Set<T>();
            this._context = _context;
        }

        //public async Task<T> Add(T obj)
        public T Add(T obj)
        {
            table.Add(obj);
            Save();
            return obj;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
            Save();
        }

        //public T Add(T obj)
        //{
        //    T t = table.Add(obj);
        //    Save();
        //    return t;
        //}

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}