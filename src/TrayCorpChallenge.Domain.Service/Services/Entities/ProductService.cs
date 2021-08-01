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

        public virtual async Task<IEnumerable<Product>> GetAllProductsOrderByAnything(int anything)
        {
            var products = await _productRepository.GetAll();
            
            switch (anything)
            {
                case 1:
                    products.OrderBy(x => x.Name);
                    break;
                case 2:
                    products.OrderBy(x => x.Inventory);
                    break;
                case 3:
                    products.OrderBy(x => x.Value);
                    break;
                default:
                    break;
            }
            return products;
        }

        public async Task<Product> GetProductByName(string name)
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
