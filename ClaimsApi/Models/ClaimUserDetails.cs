using System.Text.Json.Serialization;

namespace ClaimsApi.Models
{
    public class ClaimUserDetails
    {
        public int Id { get; set; }
        public int ClaimsId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CellPhoneNo { get; set; }
        public int HouseNo { get; set; }
        public string StreetName { get; set; }

        [JsonIgnore]
        public State State { get; set; }

        [JsonIgnore]
        public Country Country { get; set; }

        [JsonIgnore]
        public Claims Claims { get; set; }
    }
}
