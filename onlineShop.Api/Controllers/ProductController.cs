using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using onlineShopping.Models.ViewModels;
using onlineShopping.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


    }
}
