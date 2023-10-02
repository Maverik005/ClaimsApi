using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClaimsApi.Models;
using ClaimsApi.DTO;
using ClaimsApi.Interfaces;
using ClaimsApi.BLL;

namespace ClaimsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private IClaimBll _claimBll;
        public ClaimsController(IClaimBll claimBll) { 
            _claimBll = claimBll;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClaims() {
            List<ClaimDto> lstClaims = await _claimBll.GetAllClaims();
            return Ok(lstClaims);
        } 

        [HttpPost]
        public IActionResult AddClaim([FromBody] ClaimDto claim) {
            bool success = _claimBll.AddClaim(claim);
            if (!success) { return this.Problem("Claim was not saved."); }
            return this.Ok(success); //Maybe it's a good idea to return the saved object
        }

        [Route("/deleteClaim/{claimId}")]
        [HttpDelete]
        public IActionResult DeleteClaim(int claimId) {
            bool isDeleted = _claimBll.DeleteClaim(claimId);
            if (!isDeleted) { return this.Problem("Claim cannot be deleted."); }
            return Ok(isDeleted);
        }

        [HttpPatch]
        public void UpdateClaim([FromBody] ClaimDto claim) {   }
    }
}
