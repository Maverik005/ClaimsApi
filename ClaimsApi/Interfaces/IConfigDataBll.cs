using ClaimsApi.Models;

namespace ClaimsApi.Interfaces
{
    public interface IConfigDataBll
    {
        public List<State> GetStates(int countryId);
        public List<Country> GetCountries();
        public List<Manufacturer> GetManufacturers();
        public List<VehicleModels> GetVehicleModels(int manufacturerId);
    }
}
