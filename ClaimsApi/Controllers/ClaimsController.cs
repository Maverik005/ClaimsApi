using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClaimsApi.Models;

namespace ClaimsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        [HttpGet]
        public void GetClaims(int claimTypeId) { }

        [HttpPost]
        public void AddClaim([FromBody] Claims claim) { 
            
        }

        [HttpDelete]
        public void DeleteClaim(int claimId) { }

        [HttpPatch]
        public void EditClaim([FromBody] Claims claim) { }
    }
}
