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
                   
                    AvailableQuantity = productViewModel.AvailableQuantity


                };

            _productRepository.Add(product);


        }
    }
}
