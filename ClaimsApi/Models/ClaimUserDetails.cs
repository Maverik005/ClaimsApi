namespace ClaimsApi.Models
{
    public class ClaimUserDetails
    {
        public int Id { get; set; }
        public int ClaimsId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int CellPhoneNo { get; set; }
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
        public Claims Claims { get; set; }
    }
}
