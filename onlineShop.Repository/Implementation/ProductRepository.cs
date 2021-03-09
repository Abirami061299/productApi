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
    }
}
