using System.Text.Json.Serialization;

namespace ClaimsApi.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<VehicleModels> Models { get; set; }
    }
}
