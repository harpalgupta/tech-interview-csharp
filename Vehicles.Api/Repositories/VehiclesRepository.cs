using System.Text.Json;
using System;
using System.Text.Json.Serialization;

namespace Vehicles.Api.Repositories
{

    public class Vehicle
    {
        [JsonPropertyName("make")]
        public string Make { get; set; }
        [JsonPropertyName("model")]
        public string Model { get; set; }
        [JsonPropertyName("trim")]
        public string Trim { get; set; }
        [JsonPropertyName("colour")]
        public string Colour { get; set; }
    }

    public class VehiclesRepository
    {
        List<Vehicle> _vehicles;
        public VehiclesRepository()
        {
            using (StreamReader r = new StreamReader("Repositories/vehicles.json"))
            {
                string json = r.ReadToEnd();
                _vehicles = JsonSerializer.Deserialize<List<Vehicle>>(json) ?? new List<Vehicle>();
            }
        }

        public List<Vehicle> GetAll()
        {
            return _vehicles;
        }
    }
}
