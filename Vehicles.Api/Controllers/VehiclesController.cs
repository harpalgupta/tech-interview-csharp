using Microsoft.AspNetCore.Mvc;
using Vehicles.Api.Models;
using Vehicles.Api.Services;

namespace Vehicles.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly ILogger<VehiclesController> _logger;
        private readonly IVehiclesService _vehiclesService;

        public VehiclesController(ILogger<VehiclesController> logger, IVehiclesService vehiclesService)
        {
            _logger = logger;
            _vehiclesService = vehiclesService;
        }

        [HttpGet]
        public List<Vehicle> GetAllVehicles()
        {
            return _vehiclesService.GetAllVehicles();
        }
        [HttpGet("Model")]
        public List<Vehicle> GetVehiclesByModel(string model)
        {
            return _vehiclesService.GetByModel(model);
        }
        [HttpGet("Make")]
        public List<Vehicle> GetVehiclesByMake(string make)
        {
            return _vehiclesService.GetByMake(make);
        }
        [HttpGet("PriceRange")]
        public List<Vehicle> GetVehiclesByPriceRange(int? fromPrice, int? toPrice)
        {
            return _vehiclesService.GetByPrice(fromPrice, toPrice);
        }
    }
}