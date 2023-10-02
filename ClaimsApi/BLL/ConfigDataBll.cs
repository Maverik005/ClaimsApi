using ClaimsApi.Models;
using ClaimsApi.DLL;
using ClaimsApi.Interfaces;

namespace ClaimsApi.BLL
{
    public class ConfigDataBll: IConfigDataBll
    {
        public List<State> GetStates(int countryId)
        {
            try
            {
                var states = new List<State>();
                states = ConfigDataDll.GetStates(countryId);
                return states;
            } 
            catch (Exception)
            {
                throw;
            }
        }

        public List<Country> GetCountries()
        {
            try
            {
                var countries = new List<Country>();
                countries = ConfigDataDll.GetCountryList();
                return countries;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Manufacturer> GetManufacturers()
        {
            try
            {
                var manufacturers = new List<Manufacturer>();
                manufacturers = ConfigDataDll.GetManufacturerList();
                return manufacturers;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<VehicleModels> GetVehicleModels(int manufacturerId)
        {
            try
            {
                var vehicleModels = new List<VehicleModels>();
                vehicleModels = ConfigDataDll.GetVehicleModelsList(manufacturerId);
                return vehicleModels;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
