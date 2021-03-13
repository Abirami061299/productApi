using onlineShop.Repository.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShop.Repository.Interface
{
    public interface IOrderRepository
    {
        public List<Order> Get();
        public void Add(Order order);
    }
}
