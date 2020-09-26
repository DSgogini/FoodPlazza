using FoodPlazza.Domain.DTO;
using FoodPlazza.Domain.Entity;
using FoodPlazza.Domain.Repository;
using FoodPlazza.Domain.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodPlazza.BLL.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool SaveProduct(ProductDTO productDTO)
        {
            Product productEntity = new Product()
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                CreatedOn = DateTime.Now,
                IsActive = true
            };

            int response = _productRepository.Add(productEntity);
            return response > 0;
        }
    }
}
