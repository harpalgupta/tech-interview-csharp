using Newtonsoft.Json;
using Vehicles.Api.Models;

namespace Vehicles.Api.Repositories
{

    public class VehiclesRepository: IVehiclesRepository
    {

        readonly List<Vehicle> _vehicles;


        public VehiclesRepository(string path = "Repositories/vehicles.json")
        {
            _vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(File.ReadAllText(path)) ?? new List<Vehicle>(); ;
        }

        public List<Vehicle> GetAll()
        {
            return _vehicles;
        }
    }
}
