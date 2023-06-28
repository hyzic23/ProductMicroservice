using ProductMicroservice.Models;

namespace ProductMicroservice.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        List<Product> AllProducts();
        Product GetProductById(int productId);
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
        void Save();
    }
}