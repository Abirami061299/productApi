using onlineShop.Repository.EntityModel;
using onlineShopping.Models.ViewModels;
using System;
using System.Collections.Generic;


namespace onlineShopping.Services.Interface
{
    public interface IProductService
    {
        List<Product> Get();

        void Add(ProductViewModel productViewModel);
        void Update(Guid productId, ProductViewModel productViewModel);
        Product GetById(Guid ProductId);
        void Delete(Product product);

        void UpdateQuantity(Order order);
    }
}
