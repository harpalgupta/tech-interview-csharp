using System.ComponentModel;

namespace Vehicles.Api.Models
{
    public class VehicleRequest
    {
        [DefaultValue("")]
        public string Make { get; set; }
        [DefaultValue("")]
        public string Model { get; set; }
        [DefaultValue("")]
        public string Colour { get; set; }
        [DefaultValue(null)]
        public int? PriceFrom{ get; set; }
        [DefaultValue(null)]
        public int? PriceTo{ get; set; }
    }
}