using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.DataAcess.Context;
using TrayCorpChallenge.Domain.Interfaces.Repositories;
using TrayCorpChallenge.Shared.Entities;

namespace TrayCorpChallenge.DataAcess.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly ProductContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(ProductContext productContext)
        {
            Db = productContext;
            DbSet = productContext.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual  Task<TEntity> GetByName(string name)
        {
            return null;
        }

        public virtual async Task Add(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Update(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }
        public virtual async Task Delete(Guid id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public virtual async  Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
            
        }
        public void Dispose()
        {
            Db?.Dispose();
        }

    }
}
