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
    public class DronController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly Drones drones;

        public DronController(ILogger<ProductoController> logger)
        {
            _logger = logger;
            drones = new Drones();
        }

        [HttpGet]
        public IActionResult GetAllActiveDrones()
        {
            return Ok(drones.GetAllDrones());
        }

        [HttpPost]
        public IActionResult Move()
        {
            return Ok(drones.MoveDronToStoreProducts());
        }
    }
}
