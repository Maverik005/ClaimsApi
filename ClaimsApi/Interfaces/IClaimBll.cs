﻿using ClaimsApi.DTO;

namespace ClaimsApi.Interfaces
{
    public interface IClaimBll
    {
        public int AddClaim(ClaimDto claim);
        public bool DeleteClaim(int claimId);
        public Task<List<ClaimDto>> GetAllClaims();
        public bool UpdateClaim(ClaimDto claimObj);
    }
}
