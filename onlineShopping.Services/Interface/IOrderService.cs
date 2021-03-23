using onlineShop.Repository.EntityModel;
using onlineShopping.Models.ViewModels;
using System;
using System.Collections.Generic;


namespace onlineShopping.Services.Interface
{
    public interface IOrderService
    {
        List<Order> Get();
        void Add(OrderViewModel orderViewModel);
        Order GetByOrderId(Guid orderId);
        void Delete(Order order);
    }
}
