using Vehicles.Api.Models;

namespace Vehicles.Api.Services
{
    public interface IVehiclesService
    {
        List<Vehicle> GetAllVehicles();
        List<Vehicle> GetByMake(string make);
        List<Vehicle> GetByModel(string model);
        List<Vehicle> GetByPrice(int? fromPrice, int? toPrice);
    }
}