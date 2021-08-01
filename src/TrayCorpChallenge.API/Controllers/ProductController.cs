using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TrayCorpChallenge.API.DTO;
using TrayCorpChallenge.Domain.Enitites;
using TrayCorpChallenge.Domain.Interfaces.Repositories;

namespace TrayCorpChallenge.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, 
            IProductService productService, IMapper mapper)
        {
            _productRepository = productRepository;
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAll()
        {
            var product = _mapper.Map<IEnumerable<ProductDTO>>(await _productService.GetAllProducts());

            return Ok(product);
        }

        [HttpGet]
        [Route("/{name}")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>>GetByName(string name)
        {
            var product = _mapper.Map<IEnumerable<ProductDTO>>(await _productService.GetProductByName(name));

            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
        [HttpGet]
        [Route("Orderly/{field}")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>>GetAllOrderly(string field)
        {
            var products = _mapper.Map<IEnumerable<ProductDTO>>(await _productService.GetAllProductsOrderByAnything(field));

            return Ok(products);
        }
        [HttpPost]
        public async Task<ActionResult<ProductDTO>> Add(ProductDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var product = _mapper.Map<Product>(dto);

            await _productService.AddProduct(product);


            return Ok();
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ProductDTO>> Atualizar(Guid id, ProductDTO dto)
        {
            if (id != dto.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            var product = _mapper.Map<Product>(dto);

            await _productService.UpdateProduct(product);

            return Ok(product);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProductDTO>> Delete(string name)
        {
            var product = _mapper.Map<ProductDTO>(await _productService.GetProductByName(name));

            if (product == null) return NotFound();

            await _productService.Delete(product.Id);

            return Ok(product);
        }
    }
}
