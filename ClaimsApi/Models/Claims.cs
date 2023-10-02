namespace ClaimsApi.Models
{
    public class Claims
    {
        public int Id { get; set; }
        public int ClaimTypeId { get; set; }
        public string ClaimTitle { get; set; }
        public string ClaimManager { get; set; }
        public ClaimType ClaimType { get; set;}
        public ClaimUserDetails UserDetails { get; set; }
        public ClaimVehicleDetails VehicleDetails { get; set; } 

    }
}
