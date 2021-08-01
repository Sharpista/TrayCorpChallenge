using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.DataAcess.Context;
using TrayCorpChallenge.Domain.Enitites;
using TrayCorpChallenge.Domain.Interfaces.Repositories;

namespace TrayCorpChallenge.DataAcess.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductContext productContext) : base(productContext)
        {
        }
        public async Task<IEnumerable<Product>> GetByName(string name)
        {
            return await DbSet.Where(x => x.Name == name).ToListAsync();
        }
    }
}
