using SportsStore.Models;

namespace SportsStore.Data
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext _dbContext;

        public EFStoreRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Product>? Products => _dbContext.Products;
    }
}
