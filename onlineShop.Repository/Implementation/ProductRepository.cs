using onlineShop.Repository.EntityModel;
using onlineShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;


namespace onlineShop.Repository.Implementation
{
    public class ProductRepository:IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Product> Get()
        {
            return _dbContext.Product.ToList();
        }

        public void Add(Product product)
        {

            _dbContext.Add(product);
            _dbContext.SaveChanges();
        }
        public Product GetById(Guid ProductId)
        {
            return _dbContext.Product.FirstOrDefault(p => p.ProductId==ProductId);
        }
        public void Update(Product product)
        {
            
            
            _dbContext.Product.Update(product);
            _dbContext.SaveChanges();
        }
        public void Delete(Product product)
        {
            _dbContext.Product.Remove(product);
            _dbContext.SaveChanges();
        }

        public void UpdateQuantity(Order order)
        {

            Product product = GetById(order.ProductId);
            if (order.Quantity <= product.AvailableQuantity)
            {
                 product.AvailableQuantity -= order.Quantity;
                _dbContext.SaveChanges();

            }
            else
            {
                throw new Exception("Required Quantity is not available");
            }
          
           
        }
    }
}
