using EF.Core.Repository.Manager;
using RepositoryFaisal.Data;
using RepositoryFaisal.Interfaces.Manager;
using RepositoryFaisal.Models;
using RepositoryFaisal.Repository;

namespace RepositoryFaisal.Manager
{
    public class ProductManager:CommonManager<Product>,IProductManger
    {
        public ProductManager(ApplicationDbContext dbContext):base(new ProductRepository(dbContext))
        {
            
        }

        public Product GetById(int id)
        {
            return GetFirstOrDefault(c=>c.Id == id);
        }
    }
}
