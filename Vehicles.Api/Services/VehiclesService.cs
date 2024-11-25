using Vehicles.Api.Models;
using Vehicles.Api.Repositories;

namespace Vehicles.Api.Services
{
    public class VehiclesService : IVehiclesService
    {
        private readonly IVehiclesRepository vehiclesRepository;

        public VehiclesService(IVehiclesRepository vehiclesRepository)
        {
            this.vehiclesRepository = vehiclesRepository;
        }

        public List<Vehicle> GetAllVehicles()
        {
            return this.vehiclesRepository.GetAll();
        }
        
        public List<Vehicle> GetByMake(string make)
        {
            var allCars = GetAllVehicles();
            return allCars.Where(c => c.Make.Equals(make, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public List<Vehicle> GetByModel(string model)
        {
            var allCars = GetAllVehicles();
            return allCars.Where(c => c.Model.Equals(model, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public List<Vehicle> GetByPrice(int? fromPrice, int? toPrice)
        {
            var allCars = GetAllVehicles();
            if (fromPrice is not null && toPrice is not null)
            {
                return allCars.Where(c => c.Price >= fromPrice && c.Price <= toPrice).ToList();
            }
            else if(fromPrice is not null)
            {
                return allCars.Where(c => c.Price >= fromPrice).ToList();
            }
            else if (toPrice is not null)
            {
                return allCars.Where(c => c.Price <= toPrice).ToList();
            }
            throw new InvalidOperationException("No from and to price defined");
        }

    }
}
