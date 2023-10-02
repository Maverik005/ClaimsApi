using ClaimsApi.DTO;
using ClaimsApi.Helper;
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
                lstClaims = await claimsCtx.UserClaims
                            .Include(cl => cl.UserDetails)
                            .Include(cl => cl.VehicleDetails)
                            .ToListAsync();
                return lstClaims;
            }
        }
        public bool SaveClaim(ClaimDto claim)
        {
            bool isSaved = false;
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                var newClaim = new Claims
                {
                    ClaimTitle = claim.ClaimTitle,
                    ClaimManager = claim.ClaimManager,
                    ClaimTypeId = claim.ClaimTypeId,
                };

                newClaim.UserDetails = new ClaimUserDetails
                {
                    Email = claim.Email,
                    FirstName = claim.FirstName,
                    LastName = claim.LastName,
                    CellPhoneNo = claim.CellPhoneNo,
                    HouseNo = claim.HouseNo,
                    StreetName = claim.StreetName,
                    City = claim.City,
                    StateId = claim.StateId,
                    CountryId = claim.CountryId,
                };

                newClaim.VehicleDetails = new ClaimVehicleDetails
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
            }
            return isSaved; 
        }

        public bool DeleteClaim(int claimId) {
            bool isDeleted = false;
            int rowsUpdated = 0;
            using (var claimsCtx = new ClaimsContext(DBContextHelper.GetDbContextOptions()))
            {
                rowsUpdated = claimsCtx.UserClaims
                    .Where(cl => cl.Id == claimId)
                    .ExecuteUpdate(rec => rec.SetProperty(uc => uc.IsDeleted, true));
                if(rowsUpdated > 0) { isDeleted = true; }
                return isDeleted;
            }
        }
    }
}
