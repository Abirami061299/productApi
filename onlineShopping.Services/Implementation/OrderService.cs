using onlineShop.Repository.EntityModel;
using onlineShop.Repository.Interface;
using onlineShopping.Models.ViewModels;
using onlineShopping.Services.Interface;
using System;

using System.Collections.Generic;


namespace onlineShopping.Services.Implementation
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        public OrderService(IOrderRepository orderRepository,IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
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
                    CustomerId = Guid.NewGuid(),
                    Quantity = orderViewModel.Quantity,
                    TotalPrice = orderViewModel.TotalPrice,
                    OrderedDate = DateTime.UtcNow,
                    DeliveryDate = DateTime.UtcNow.AddDays(7)

                };
           
            
           

            _orderRepository.Add(order);
            _productRepository.UpdateQuantity(order);


        }
        public Order GetByOrderId(Guid orderId)
        {
            return _orderRepository.GetByOrderId(orderId);
        }

        public void Delete(Order order)
        {
            _orderRepository.Delete(order);
        }
    }
}
