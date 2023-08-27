using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using RepositoryFaisal.Interfaces.Repository;
using RepositoryFaisal.Models;

namespace RepositoryFaisal.Repository
{
    public class ProductRepository : CommonRepository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
