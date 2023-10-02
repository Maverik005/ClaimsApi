using ClaimsApi.DTO;
using ClaimsApi.Interfaces;
using ClaimsApi.Models;
using ClaimsApi.DLL;

namespace ClaimsApi.BLL
{
    public class ClaimBll : IClaimBll
    {
        public bool AddClaim(ClaimDto claim)
        {
            try
            {
                bool isSaved = false;
                ClaimDll dllObj = new ClaimDll();
                isSaved = dllObj.SaveClaim(claim);
                return isSaved;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool DeleteClaim(int claimId)
        {
            try
            {
                bool isDeleted = false;
                ClaimDll dllObj = new ClaimDll();
                isDeleted = dllObj.DeleteClaim(claimId);
                return isDeleted;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ClaimDto>> GetAllClaims()
        {
            try
            {
                List<Claims> lstClaims = new List<Claims>();
                List<ClaimDto> lstClaimsDto = new List<ClaimDto>();
                ClaimDll dllObj = new ClaimDll();

                lstClaims = await dllObj.GetClaimsList();

                foreach (var claim in lstClaims)
                {
                    ClaimDto claimObj = new ClaimDto();
                    //Claim Info
                    claimObj.Id = claim.Id;
                    claimObj.ClaimTypeId = claim.ClaimTypeId;
                    claimObj.ClaimTitle = claim.ClaimTitle;
                    claimObj.ClaimManager = claim.ClaimManager;
                    // claim user info
                    claimObj.FirstName = claim.UserDetails.FirstName;
                    claimObj.LastName = claim.UserDetails.LastName;
                    claimObj.Email = claim.UserDetails.Email;
                    claimObj.CellPhoneNo = claim.UserDetails.CellPhoneNo;
                    claimObj.HouseNo = claim.UserDetails.HouseNo;
                    claimObj.StreetName = claim.UserDetails.StreetName;
                    claimObj.City = claim.UserDetails.City;
                    claimObj.StateId = claim.UserDetails.StateId;
                    claimObj.CountryId = claim.UserDetails.CountryId;
                    claimObj.UserId = claim.UserDetails.Id;
                    //claim vehicle info
                    claimObj.VehicleFIN = claim.VehicleDetails.VehicleFIN;
                    claimObj.VehicleId = claim.VehicleDetails.Id;
                    claimObj.ManufacturerId = claim.VehicleDetails.ManufacturerId;
                    claimObj.ModelId = claim.VehicleDetails.ModelId;
                    claimObj.ManufacturingDate  = claim.VehicleDetails.ManufacturingDate;
                    claimObj.DateOfPurchase = claim.VehicleDetails.DateOfPurchase;
                    claimObj.PurchasePrise = claim.VehicleDetails.PurchasePrise;
                    claimObj.KilometersDriven   = claim.VehicleDetails.KilometersDriven;
                    lstClaimsDto.Add(claimObj);
                }

                return lstClaimsDto;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
