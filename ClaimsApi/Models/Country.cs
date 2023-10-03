using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClaimsApi.Models
{
    [DataContract]
    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<ClaimUserDetails> UserDetails { get; set; }

        [JsonIgnore]
        public ICollection<State> States { get; set; }

    }
}
