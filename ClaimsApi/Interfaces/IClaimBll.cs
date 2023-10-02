using ClaimsApi.DTO;

namespace ClaimsApi.Interfaces
{
    public interface IClaimBll
    {
        public bool AddClaim(ClaimDto claim);
        public bool DeleteClaim(int claimId);
        public Task<List<ClaimDto>> GetAllClaims();
    }
}
