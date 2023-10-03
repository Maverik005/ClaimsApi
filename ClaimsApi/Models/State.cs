using System.Text.Json.Serialization;

namespace ClaimsApi.Models
{
    public class State
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<ClaimUserDetails> UserDetails { get; set; }

        [JsonIgnore]
        public Country Country { get; set; }
    }
}
