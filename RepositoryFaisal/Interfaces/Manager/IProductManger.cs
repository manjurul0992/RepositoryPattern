using EF.Core.Repository.Interface.Manager;
using RepositoryFaisal.Models;

namespace RepositoryFaisal.Interfaces.Manager
{
    public interface IProductManger:ICommonManager<Product>
    {
        Product GetById(int id);
    }
}
