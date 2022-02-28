using SportsStore.Models;

namespace SportsStore.Data
{
    public interface IStoreRepository
    {
        IQueryable<Product>? Products { get; }
    }
}
