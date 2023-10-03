using System.Text.Json.Serialization;

namespace ClaimsApi.Models
{
    public class Claims
    {
        public int Id { get; set; }
        public int ClaimTypeId { get; set; }
        public string ClaimTitle { get; set; }
        public string ClaimManager { get; set; }
        public bool IsDeleted { get; set; }

        [JsonIgnore]
        public ClaimType ClaimType { get; set;}
        public ClaimUserDetails UserDetails { get; set; }
        public ClaimVehicleDetails VehicleDetails { get; set; } 

    }
}
