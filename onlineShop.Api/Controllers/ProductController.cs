using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using onlineShop.Repository.EntityModel;
using onlineShopping.Models.ViewModels;
using onlineShopping.Services.Interface;
using System;

namespace onlineShop.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.Get());
        }

        [HttpPost]
        public IActionResult Add([FromBody] ProductViewModel productViewModel)
        {
            _productService.Add(productViewModel);
            return Ok("product added!!!");
        }


        [HttpGet("{ProductId}", Name = "Get")]
        public IActionResult GetById(Guid ProductId)
        {
            Product product = _productService.GetById(ProductId);
            if (product == null)
            {
               
                return NotFound("The product details couldn't be found.");
            }
            return Ok(product);
        }

        [HttpPut("{ProductId}")]
        public IActionResult Put(Guid ProductId, [FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("product is null.");
            }
            Product productToUpdate = _productService.GetById(ProductId);
            if (productToUpdate == null)
            {
                return NotFound("The product details couldn't be found.");
            }
            _productService.Update(productToUpdate, product);
            return NoContent();
        }

        [HttpDelete("{ProductId}")]
        public IActionResult Delete(Guid ProductId)
        {
            Product product = _productService.GetById(ProductId);
            if (product == null)
            {
                return NotFound("The product details couldn't be found.");
            }
            _productService.Delete(product);
            return NoContent();
        }



    }
}
