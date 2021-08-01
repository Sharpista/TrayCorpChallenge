using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Domain.Enitites;
using TrayCorpChallenge.Domain.Enumerator;
using TrayCorpChallenge.Domain.Interfaces.Repositories;

namespace TrayCorpChallenge.Domain.Service.Services.Entities
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public virtual async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAll();
        }

        public virtual async Task<IEnumerable<Product>> GetAllProductsOrderByAnything(string anything)
        {
            var products = await _productRepository.GetAll();

            if (anything == "Name")
                products.OrderBy(x => x.Name);

            else if (anything == "Inventory")
                products.OrderBy(x => x.Inventory);

            else if (anything == "Value")
                products.OrderBy(x => x.Value);

            else
                return null;
            
            return products;
        }

        public virtual async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            return await _productRepository.GetByName(name);
        }
        public async Task AddProduct(Product entity)
        {
            await _productRepository.Add(entity);
        }

        public async Task Delete(Guid id)
        {
            await _productRepository.Delete(id);
        }

        public async Task UpdateProduct(Product entity)
        {
            await _productRepository.Add(entity);
        }
        public void Dispose()
        {
            _productRepository?.Dispose();
        }

    }
}
