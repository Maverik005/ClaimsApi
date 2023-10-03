using System.Text.Json.Serialization;

namespace ClaimsApi.Models
{
    public class VehicleModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }

        [JsonIgnore]
        public Manufacturer Manufacturer { get; set; } 
    }
}
