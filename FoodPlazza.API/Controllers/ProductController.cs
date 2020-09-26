using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodPlazza.Domain.DTO;
using FoodPlazza.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodPlazza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("Add")]
        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductDTO requestDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = _productService.SaveProduct(requestDTO);
            return Ok(response);
        }
    }
}
