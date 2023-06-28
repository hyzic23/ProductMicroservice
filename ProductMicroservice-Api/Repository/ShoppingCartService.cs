using IRepository;
//using ProductMicroservice.IRepository;
using ProductMicroservice.DBContexts;
using ProductMicroservice.Models;

namespace Repository;

public class ShoppingCartService : IShoppingCartService
{
    private readonly ProductContext _dbContext;
    public ShoppingCartService(ProductContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ShoppingItem Add(ShoppingItem newItem) => throw new NotImplementedException();
    public IEnumerable<ShoppingItem> GetAllItems() => throw new NotImplementedException();
    public ShoppingItem GetById(Guid id) => throw new NotImplementedException();
    public void Remove(Guid id) => throw new NotImplementedException();
}