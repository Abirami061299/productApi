using onlineShop.Repository.EntityModel;
using onlineShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public void Update(Product product, Product entity)
        {
            
            product.ProductName = entity.ProductName;
            product.AvailableQuantity = entity.AvailableQuantity;
            product.UnitPrice = entity.UnitPrice;
            product.ModifiedDate = DateTime.UtcNow;
            
            _dbContext.SaveChanges();
        }
        public void Delete(Product product)
        {
            _dbContext.Product.Remove(product);
            _dbContext.SaveChanges();
        }
    }
}
