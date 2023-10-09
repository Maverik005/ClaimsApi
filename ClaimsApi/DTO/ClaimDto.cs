namespace ClaimsApi.DTO
{
    public class ClaimDto
    {
        public int? Id { get; set; }
        public string ClaimTitle { get; set; }
        public int ClaimTypeId { get; set; }
        public string? ClaimManager { get; set; }
        public int? UserId { get; set; }
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
        public int? VehicleId { get; set; }
        public int ManufacturerId { get; set; }
        public int ModelId { get; set; }
        public string VehicleFIN { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public int KilometersDriven { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public double PurchasePrise { get; set; }
    }
}
