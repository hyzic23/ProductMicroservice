using ProductMicroservice.Models;

namespace IRepository
{
    public interface IShoppingCartService
    {
        IEnumerable<ShoppingItem> GetAllItems();
        ShoppingItem Add(ShoppingItem newItem);
        ShoppingItem GetById(Guid Id);
        void Remove(Guid id);
    }
}