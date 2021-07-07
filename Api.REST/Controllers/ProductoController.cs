using Api.REST.Models;
using Api.REST.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly Products products;

        public ProductoController(ILogger<ProductoController> logger)
        {
            _logger = logger;
            products = new Products();
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(products.GetAllProducts());
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            return Ok(products.UpdateProduct(product));
        }
    }
}
