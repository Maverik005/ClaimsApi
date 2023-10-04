using ClaimsApi.Models;
using ClaimsApi.Helper.Helper;
using Microsoft.EntityFrameworkCore;

namespace ClaimsApi.DLL
{
    public static class ConfigDataDll
    {
        public static List<State> GetStates(int countryId) { 
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                var lstStates = new List<State>();
                lstStates = claimsCtx.States.AsNoTracking().Where(s => s.CountryId == countryId).ToList();
                return lstStates;
            } 
        }

        public static List<Country> GetCountryList() {
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                var lstCountries = new List<Country>();
                lstCountries = claimsCtx.Countries.AsNoTracking().ToList();
                return lstCountries;
            }
        }

        public static List<Manufacturer> GetManufacturerList()
        {
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                var lstManufacturers = new List<Manufacturer>();
                lstManufacturers = claimsCtx.Manufacturers.AsNoTracking().ToList();
                return lstManufacturers;
            }
        }

        public static List<VehicleModels> GetVehicleModelsList(int manufacturerId) {
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                var lstModels = new List<VehicleModels>();
                lstModels = claimsCtx.VehicleModels.AsNoTracking() .Where(m=> m.ManufacturerId == manufacturerId).ToList();
                return lstModels;
            }
        }
    }
}