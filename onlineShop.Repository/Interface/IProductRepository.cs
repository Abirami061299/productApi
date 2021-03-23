using onlineShop.Repository.EntityModel;
using System;
using System.Collections.Generic;


namespace onlineShop.Repository.Interface
{
    public interface IProductRepository
    {
        List<Product> Get();
        void Add(Product product);
        void Update(Product product);
        Product GetById(Guid ProductId);

        void Delete(Product product);
        void UpdateQuantity(Order order);
    }
}
