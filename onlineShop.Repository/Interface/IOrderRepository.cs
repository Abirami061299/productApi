using onlineShop.Repository.EntityModel;
using System;
using System.Collections.Generic;

namespace onlineShop.Repository.Interface
{
    public interface IOrderRepository
    {
        public List<Order> Get();
        public void Add(Order order);
        Order GetByOrderId(Guid orderId);
        void Delete(Order order);
    }
}
