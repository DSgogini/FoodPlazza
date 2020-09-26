using FoodPlazza.DAL.Data;
using FoodPlazza.Domain.Entity;
using FoodPlazza.Domain.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace FoodPlazza.DAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly FoodPlazzaDbContext _context;
        public ProductRepository(FoodPlazzaDbContext context)
        {
            _context = context;
        }

        public int Add(Product product)
        {
            _context.Product.Add(product);
            return _context.SaveChanges();
        }

        public List<Product> Get()
        {
            throw new NotImplementedException();
        }
    }
}
