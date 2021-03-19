using Microsoft.EntityFrameworkCore;
using onlineShop.Repository.EntityModel;
using onlineShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return _dbContext.Order.Include(obj => obj.Product).ToList();
        }

        public void Add(Order order)
        {

            _dbContext.Add(order);
            _dbContext.SaveChanges();
        }
        public Order GetByOrderId(Guid OrderId)
        {
            return _dbContext.Order.FirstOrDefault(o=> o.OrderId == OrderId);
        }
        public void Delete(Order order)
        {
            _dbContext.Order.Remove(order);
            _dbContext.SaveChanges();
        }
    }
}
