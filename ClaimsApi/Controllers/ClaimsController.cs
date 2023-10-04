using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClaimsApi.Models;
using ClaimsApi.DTO;
using ClaimsApi.Interfaces;
using ClaimsApi.BLL;
using ClaimsApi.Helper;
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

        [HttpGet]
        public async Task<IActionResult> GetAllClaims() {
            List<ClaimDto> lstClaims = await _claimBll.GetAllClaims();
            return Ok(lstClaims);
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddClaim([FromBody] ClaimDto claim) {
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            claim.ClaimManager = ClaimsHelper.GetLoggedInUserEmail(principal);
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

        [Route("/updateClaim")]
        [HttpPost]
        public IActionResult UpdateClaim([FromBody] ClaimDto claim) {
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;
            claim.ClaimManager = ClaimsHelper.GetLoggedInUserEmail(principal);
            bool isUpdated =  _claimBll.UpdateClaim(claim);
            if (!isUpdated) { return this.Problem("Claim cannot be updated"); }
            return Ok(isUpdated);
        }
    }
}
