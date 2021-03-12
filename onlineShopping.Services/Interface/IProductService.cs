using onlineShop.Repository.EntityModel;
using onlineShopping.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShopping.Services.Interface
{
    public interface IProductService
    {
        List<Product> Get();

        void Add(ProductViewModel productViewModel);
        void Update(Product product, Product entity);
        Product GetById(Guid ProductId);
        void Delete(Product product);
    }
}
