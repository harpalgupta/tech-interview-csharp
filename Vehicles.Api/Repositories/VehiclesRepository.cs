using Newtonsoft.Json;
using Vehicles.Api.Models;

namespace Vehicles.Api.Repositories
{

    public class VehiclesRepository: IVehiclesRepository
    {
        private const string Path = "Repositories/vehicles.json";
        readonly List<Vehicle> _vehicles;

        public VehiclesRepository()
        {
            _vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(File.ReadAllText(Path)) ?? new List<Vehicle>(); ;
        }

        public List<Vehicle> GetAll()
        {
            return _vehicles;
        }
    }
}
