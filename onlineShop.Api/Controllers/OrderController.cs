
using Microsoft.AspNetCore.Mvc;
using onlineShopping.Services.Interface;
using onlineShop.Repository.EntityModel;
using onlineShopping.Models.ViewModels;
using System;

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
       [HttpDelete("{OrderId}")]
        public IActionResult Delete(Guid OrderId)
        {
            Order order  = _orderService.GetByOrderId(OrderId);
            if (order == null)
            {
                return NotFound("The product details couldn't be found.");
            }
            _orderService.Delete(order);
            return NoContent();
        }
        [HttpGet("{OrderId}", Name = "GetByOrderId")]
        public IActionResult GetByOrderId(Guid OrderId)
        {
            Order order = _orderService.GetByOrderId(OrderId);
            if (order == null)
            {

                return NotFound("The order details couldn't be found.");
            }
            return Ok(order);
        }


    }
}
