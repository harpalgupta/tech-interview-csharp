using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Vehicles.Api.Models
{
    public class Vehicle
    {
        [JsonPropertyName("make")]
        [JsonRequired]
        public string Make { get; set; }

        [JsonPropertyName("model")]
        [JsonRequired]
        public string Model { get; set; }

        [JsonPropertyName("trim")]
        public string Trim { get; set; }

        [JsonPropertyName("colour")]
        [JsonRequired]
        public string Colour { get; set; }

        [JsonPropertyName("price")]
        [JsonRequired]
        public int Price { get; set; }

        [JsonPropertyName("co2_level")]
        public int Co2Level { get; set; }

        [JsonPropertyName("transmission")]
        [JsonRequired]
        public string Transmission { get; set; }

        [JsonPropertyName("fuel_type")]
        public string FuelType { get; set; }

        [JsonPropertyName("engine_size")]
        [JsonRequired]
        public int Engine_size { get; set; }

        [JsonPropertyName("date_first_reg")]
        public DateTime DateFirstRegistered { get; set; }

        [JsonPropertyName("mileage")]
        [JsonRequired]

        public int Mileage { get; set; }
    }
}
