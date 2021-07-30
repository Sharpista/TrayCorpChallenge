using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrayCorpChallenge.Domain.Enitites;
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
            return await _productRepository.GetAllProducts();
        }

        public virtual async Task<IEnumerable<Product>> GetAllProductsOrderByAnything(string anything)
        {
            var products = await _productRepository.GetAllProducts();

            switch (anything)
            {
                case "Inventoy":
            }
        }

        public Task<Product> GetProductByName(string name)
        {
            throw new NotImplementedException();
        }
        public Task AddProduct(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public Task UpdateProduct(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
