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
            IEnumerable<Product> order;

            if (anything == "Name")
            {
                order = from p in products orderby p.Name select p;
            }

            else if (anything == "Inventory")
            {
                order = from p in products orderby p.Inventory select p;

            }

            else if (anything == "Value")
            {
                order = from p in products orderby p.Value select p;

            }

            else
            {
                return null;

            }
            
            return order;
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
            await _productRepository.Up(entity);
        }
        public void Dispose()
        {
            _productRepository?.Dispose();
        }

        public async  Task<Product> GetProductById(Guid id)
        {
            return await _productRepository.GetById(id);
        }
    }
}
