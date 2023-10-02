using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClaimsApi.Interfaces;
using ClaimsApi.Models;

namespace ClaimsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigDataController : ControllerBase
    {
        private IConfigDataBll _configDataBll;
        public ConfigDataController(IConfigDataBll iConfigDataBll) { 
            _configDataBll = iConfigDataBll;
        }

        [Route("/GetStates/{countryId}")]
        [HttpGet] 
        public IActionResult GetStates(int countryId) { 
            var lstStates = new List<State>();
            lstStates = _configDataBll.GetStates(countryId);
            return Ok(lstStates);
        }

        [Route("/GetCountries")]
        [HttpGet]
        public IActionResult GetCountries()
        {
            var lstCountries = new List<Country>();
            lstCountries = _configDataBll.GetCountries();
            return Ok(lstCountries);
        }

        [Route("/GetManufacturers")]
        [HttpGet]
        public IActionResult GetManufacturers()
        {
            var lstManufacturers = new List<Manufacturer>();
            lstManufacturers = _configDataBll.GetManufacturers();
            return Ok(lstManufacturers);
        }

        [Route("/GetVehicleModels/{manufacturerId}")]
        [HttpGet]
        public IActionResult GetVehicleModels(int manufacturerId)
        {
            var lstModels = new List<VehicleModels>();
            lstModels = _configDataBll.GetVehicleModels(manufacturerId);
            return Ok(lstModels);
        }
    }
}
