﻿using onlineShop.Repository.EntityModel;
using onlineShop.Repository.Interface;
using onlineShopping.Models.ViewModels;
using onlineShopping.Services.Interface;
using System;
using System.Collections.Generic;


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
        public void Update(Guid ProductId, ProductViewModel productViewModel)
        {
            var productToUpdate = GetById(ProductId);

            if (productToUpdate == null)
            {
                throw new Exception("The Product record couldn't be found.");
            }

            productToUpdate.ProductName = productViewModel.ProductName;
            productToUpdate.AvailableQuantity = productViewModel.AvailableQuantity;
            productToUpdate.UnitPrice = productViewModel.UnitPrice;
            productToUpdate.ModifiedDate = DateTime.UtcNow;
            _productRepository.Update(productToUpdate);

            
           
            
        }
        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }
        public void UpdateQuantity(Order order)
        {
            _productRepository.UpdateQuantity(order);
        }
    }
}
