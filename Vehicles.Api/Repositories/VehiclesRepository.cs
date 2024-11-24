using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.IO;
using System.Reflection.PortableExecutable;
using Vehicles.Api.Models;

namespace Vehicles.Api.Repositories
{

    public class VehiclesRepository
    {
        readonly List<Vehicle> _vehicles;

        public VehiclesRepository()
        {
            _vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(File.ReadAllText("Repositories/vehicles.json")) ?? new List<Vehicle>(); ;
        }

        public List<Vehicle> GetAll()
        {
            return _vehicles;
        }
    }
}
