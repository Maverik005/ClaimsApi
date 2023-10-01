namespace ClaimsApi.Models
{
    public class ClaimType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Claims> UserClaims { get; set; }

    }
}
