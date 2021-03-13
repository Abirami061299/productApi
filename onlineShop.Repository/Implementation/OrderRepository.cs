using onlineShop.Repository.EntityModel;
using onlineShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace onlineShop.Repository.Implementation
{
    public class OrderRepository:IOrderRepository
    {
        private readonly AppDbContext _dbContext;

        public OrderRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Order> Get()
        {
            return _dbContext.Order.ToList();
        }

        public void Add(Order order)
        {

            _dbContext.Add(order);
            _dbContext.SaveChanges();
        }
    }
}
