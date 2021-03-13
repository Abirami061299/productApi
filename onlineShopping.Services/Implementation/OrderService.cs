using onlineShop.Repository.EntityModel;
using onlineShop.Repository.Interface;
using onlineShopping.Models.ViewModels;
using onlineShopping.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShopping.Services.Implementation
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> Get()
        {
            return _orderRepository.Get();
        }

        public void Add(OrderViewModel orderViewModel)
        {

            var order
                = new Order()
                {
                    
                    ProductId = orderViewModel.ProductId,
                    Quantity =orderViewModel.Quantity,
                    TotalPrice=orderViewModel.TotalPrice,
                    CreatedDate = DateTime.UtcNow,
                    
                };

            _orderRepository.Add(order);


        }
    }
}
