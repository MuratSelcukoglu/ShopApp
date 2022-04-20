using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.entity;

namespace shopapp.webapi.Controllers
{
    //localhost:4200/api/prdoucts
    //localhost:4200/api/prdoucts/2
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var p = await _productService.GetById(id);
            if (p == null)
            {
                return NotFound(); // 404
            }
            return Ok(p); //200 kodu gidecek
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product entity)
        {
            await _productService.CreateAsync(entity);
            return CreatedAtAction(nameof(GetProduct), new { id = entity.ProductId }, entity);
        }
        //localhost:5000/api/controller/2
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product entity)
        {
            if (id != entity.ProductId)
            {
                return BadRequest();
            }
            var product = await _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            await _productService.UpdateAsync(product, entity);
            return NoContent();
        }
    }
}