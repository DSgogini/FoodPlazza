using FoodPlazza.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodPlazza.Domain.Service
{
    public interface IProductService
    {
        bool SaveProduct(ProductDTO productDTO);
    }
}
