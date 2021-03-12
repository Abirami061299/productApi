using onlineShop.Repository.EntityModel;
using onlineShop.Repository.Interface;
using onlineShopping.Models.ViewModels;
using onlineShopping.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace onlineShopping.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public List<Product> Get()
        {
            return _productRepository.Get();
        }

        public void Add(ProductViewModel productViewModel)
        {

            var product
                = new Product()
                {
                    ProductId = productViewModel.ProductId,
                    ProductName = productViewModel.ProductName,
                    UnitPrice=productViewModel.UnitPrice,
                    AvailableQuantity = productViewModel.AvailableQuantity,

                    CreatedDate = DateTime.UtcNow
                };

            _productRepository.Add(product);


        }
        public Product GetById(Guid ProductId)
        {
            return _productRepository.GetById(ProductId);
        }
        public void Update(Product product, Product entity)
        {

            product.ProductName = entity.ProductName;
            product.AvailableQuantity = entity.AvailableQuantity;
            product.UnitPrice= entity.UnitPrice;
            product.ModifiedDate = DateTime.UtcNow;
            _productRepository.Update(product, entity);
        }
        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }
    }
}
