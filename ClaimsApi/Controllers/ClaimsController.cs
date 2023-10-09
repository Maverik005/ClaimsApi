using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClaimsApi.DTO;
using ClaimsApi.Interfaces;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

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

        [Authorize(Roles = "DieselClaimManager,admin,ClaimManager")]
        [HttpGet]
        public async Task<IActionResult> GetAllClaims() {
            List<ClaimDto> lstClaims = await _claimBll.GetAllClaims();
            return Ok(lstClaims);
        }

        [Authorize(Roles = "DieselClaimManager,admin")]
        [HttpPost]
        public IActionResult AddClaim([FromBody] ClaimDto claim) {
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            //claim.ClaimManager = ClaimsHelper.GetLoggedInUserEmail(principal);
            int newId = _claimBll.AddClaim(claim);
            if (newId == 0) { return this.Problem("Claim was not saved."); }   
            return this.Ok(newId); //Maybe it's a good idea to return the saved object
        }

        [Authorize(Roles = "DieselClaimManager,admin")]
        [Route("/deleteClaim/{claimId}")]
        [HttpDelete]
        public IActionResult DeleteClaim(int claimId) {
            bool isDeleted = _claimBll.DeleteClaim(claimId);
            if (!isDeleted) { return this.Problem("Claim cannot be deleted."); }
            return Ok(isDeleted);
        }

        [Authorize(Roles = "DieselClaimManager,admin")]
        [Route("/updateClaim")]
        [HttpPost]
        public IActionResult UpdateClaim([FromBody] ClaimDto claim) {
            //ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            //claim.ClaimManager = ClaimsHelper.GetLoggedInUserEmail(principal);
            bool isUpdated =  _claimBll.UpdateClaim(claim);
            return Ok(isUpdated);
        }
    }
}
