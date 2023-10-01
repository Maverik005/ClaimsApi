namespace ClaimsApi.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<VehicleModels> Models { get; set; }
    }
}
