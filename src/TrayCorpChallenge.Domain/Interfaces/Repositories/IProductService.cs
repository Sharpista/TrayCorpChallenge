using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Domain.Enitites;

namespace TrayCorpChallenge.Domain.Interfaces.Repositories
{
    public interface IProductService : IDisposable
    {
        Task AddProduct(Product entity);
        Task<IEnumerable<Product>>GetProductByName(string name);
        Task<IEnumerable<Product>> GetAllProducts();
        Task UpdateProduct(Product entity);
        Task<Product> GetProductById(Guid id);
        Task Delete(Guid id);
        Task<IEnumerable<Product>> GetAllProductsOrderByAnything(string anything);
    }
}
