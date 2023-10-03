using System.Text.Json.Serialization;

namespace ClaimsApi.Models
{
    public class ClaimType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Claims> UserClaims { get; set; }

    }
}
