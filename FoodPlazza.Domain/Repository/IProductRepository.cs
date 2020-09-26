using FoodPlazza.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodPlazza.Domain.Repository
{
    public interface IProductRepository
    {
        int Add(Product product);
        List<Product> Get();
    }
}
