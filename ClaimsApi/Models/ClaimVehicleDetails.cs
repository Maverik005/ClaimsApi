using System.Numerics;
using System.Text.Json.Serialization;

namespace ClaimsApi.Models
{
    public class ClaimVehicleDetails
    {
        public int Id { get; set; }
        public int ClaimsId { get; set; }
        public int ManufacturerId { get; set; }
        public int ModelId { get; set; }
        public string VehicleFIN { get; set;}
        public DateTime ManufacturingDate { get; set;}
        public int KilometersDriven { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public double PurchasePrise { get; set; }

        [JsonIgnore]
        public Claims Claims { get; set; }
          
    }
}
