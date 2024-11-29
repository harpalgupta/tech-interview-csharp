using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Vehicles.Api.Models
{
    public class Vehicle
    {
        [JsonProperty("make")]
        [JsonRequired]
        public string Make { get; set; }

        [JsonProperty("model")]
        [JsonRequired]
        public string Model { get; set; }

        [JsonProperty("trim")]
        public string Trim { get; set; }

        [JsonProperty("colour")]
        [JsonRequired]
        public string Colour { get; set; }

        [JsonProperty("price")]
        [JsonRequired]
        public int Price { get; set; }

        [JsonProperty("co2_level")]
        public int co2_level { get; set; }

        [JsonProperty("transmission")]
        [JsonRequired]
        public string Transmission { get; set; }

        [JsonProperty("fuel_type")]
        public string FuelType { get; set; }

        [JsonProperty("engine_size")]
        [JsonRequired]
        public int Engine_size { get; set; }

        [JsonProperty("date_first_reg")]
        public DateTime DateFirstRegistered { get; set; }

        [JsonProperty("mileage")]
        [JsonRequired]

        public int Mileage { get; set; }
    }
}
