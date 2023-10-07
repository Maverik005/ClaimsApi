using ClaimsApi.DTO;
using ClaimsApi.Helper.Helper;
using ClaimsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;

namespace ClaimsApi.DLL
{
    public class ClaimDll
    {
        public async Task<List<Claims>> GetClaimsList()
        {
            List<Claims> lstClaims = new List<Claims>();
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions())) { 
                lstClaims = await claimsCtx.Claims
                            .Where(c => c.IsDeleted == false)
                            .Include(cl => cl.ClaimUserDetails)
                            .Include(cl => cl.ClaimVehicleDetails)
                            .ToListAsync();
                return lstClaims;
            }
        }
        public int SaveClaim(ClaimDto claim)
        {
            int claimId = 0;
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                var newClaim = new Claims
                {
                    ClaimTitle = claim.ClaimTitle,
                    ClaimManager = claim.ClaimManager,
                    ClaimTypeId = claim.ClaimTypeId,
                    IsDeleted = false
                };

                newClaim.ClaimUserDetails = new ClaimUserDetails
                {
                    Email = claim.Email,
                    FirstName = claim.FirstName,
                    LastName = claim.LastName,
                    CellPhoneNo = claim.CellPhoneNo,
                    HouseNo = claim.HouseNo,
                    StreetName = claim.StreetName,
                    Pincode = claim.Pincode,
                    City = claim.City,
                    StateId = claim.StateId,
                    CountryId = claim.CountryId,
                };

                newClaim.ClaimVehicleDetails = new ClaimVehicleDetails
                {
                    VehicleFIN = claim.VehicleFIN,
                    ManufacturerId = claim.ManufacturerId,
                    ModelId = claim.ModelId,
                    DateOfPurchase = claim.DateOfPurchase,
                    ManufacturingDate = claim.ManufacturingDate,
                    KilometersDriven = claim.KilometersDriven,
                    PurchasePrise = claim.PurchasePrise,
                };

                claimsCtx.Add(newClaim);
                claimsCtx.SaveChanges();
                claimId = newClaim.Id;
            }
            return claimId; 
        }

        public bool DeleteClaim(int claimId) {
            bool isDeleted = false;
            int rowsUpdated = 0;
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                rowsUpdated = claimsCtx.Claims
                    .Where(cl => cl.Id == claimId)
                    .ExecuteUpdate(rec => rec.SetProperty(uc => uc.IsDeleted, true));
                if(rowsUpdated > 0) { isDeleted = true; }
                return isDeleted;
            }
        }

        public bool UpdateClaim( Claims claim)
        {
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                bool isUpdated = false;
                int rowsUpdated = 0;
                claimsCtx.Claims.Update(claim);
                rowsUpdated = claimsCtx.SaveChanges();
                if(rowsUpdated > 0) { isUpdated = true; }
                return isUpdated;
            }
        }
    }
}
