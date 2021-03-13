using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using onlineShopping.Services.Interface;
using onlineShop.Repository.EntityModel;
using onlineShopping.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineShop.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]

  
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.Get());
        }

        [HttpPost]
        public IActionResult Add([FromBody] OrderViewModel orderViewModel)
        {
            _orderService.Add(orderViewModel);
            return Ok("product ordered!!!");
        }

    }
}
