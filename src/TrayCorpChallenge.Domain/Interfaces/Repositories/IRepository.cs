using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Shared.Entities;

namespace TrayCorpChallenge.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task AddProduct(TEntity entity);
        Task<TEntity> GetProductByName(string name);
        Task<IEnumerable<TEntity>> GetAllProducts();
        Task UpdateProduct(TEntity entity);
        Task Delete(Guid id);
        Task<int> SaveChanges();

    }
}
