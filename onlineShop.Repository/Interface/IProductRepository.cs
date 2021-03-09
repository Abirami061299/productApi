using onlineShop.Repository.EntityModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShop.Repository.Interface
{
   public  interface IProductRepository
    {
        List<Product> Get();
        void Add(Product product);
    }
}
