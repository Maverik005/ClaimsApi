namespace ClaimsApi.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ClaimUserDetails> UserDetails { get; set; }
        public ICollection<State> States { get; set; }

    }
}
