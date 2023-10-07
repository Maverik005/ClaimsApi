using ClaimsApi.DTO;
using ClaimsApi.Interfaces;
using ClaimsApi.Models;
using ClaimsApi.DLL;
using System.Security.Claims;

namespace ClaimsApi.BLL
{
    public class ClaimBll : IClaimBll
    {
        public int AddClaim(ClaimDto claim)
        {
            try
            {
                int claimId = 0;
                ClaimDll dllObj = new ClaimDll();
                claimId = dllObj.SaveClaim(claim);
                return claimId;
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
                    claimObj.FirstName = claim.ClaimUserDetails.FirstName;
                    claimObj.LastName = claim.ClaimUserDetails.LastName;
                    claimObj.Email = claim.ClaimUserDetails.Email;
                    claimObj.CellPhoneNo = claim.ClaimUserDetails.CellPhoneNo;
                    claimObj.HouseNo = claim.ClaimUserDetails.HouseNo;
                    claimObj.StreetName = claim.ClaimUserDetails.StreetName;
                    claimObj.City = claim.ClaimUserDetails.City;
                    claimObj.Pincode = claim.ClaimUserDetails.Pincode;
                    claimObj.StateId = claim.ClaimUserDetails.StateId;
                    claimObj.CountryId = claim.ClaimUserDetails.CountryId;
                    claimObj.UserId = claim.ClaimUserDetails.Id;
                    //claim vehicle info
                    claimObj.VehicleFIN = claim.ClaimVehicleDetails.VehicleFIN;
                    claimObj.VehicleId = claim.ClaimVehicleDetails.Id;
                    claimObj.ManufacturerId = claim.ClaimVehicleDetails.ManufacturerId;
                    claimObj.ModelId = claim.ClaimVehicleDetails.ModelId;
                    claimObj.ManufacturingDate  = claim.ClaimVehicleDetails.ManufacturingDate;
                    claimObj.DateOfPurchase = claim.ClaimVehicleDetails.DateOfPurchase;
                    claimObj.PurchasePrise = claim.ClaimVehicleDetails.PurchasePrise;
                    claimObj.KilometersDriven   = claim.ClaimVehicleDetails.KilometersDriven;
                    lstClaimsDto.Add(claimObj);
                }

                return lstClaimsDto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateClaim( ClaimDto claimObj)
        {
            try
            {
                bool isUpdated = false;
                Claims claim = new Claims();
                ClaimDll dllObj = new ClaimDll();
                //Claim Info
                claim.Id = claimObj.Id == null ? 0 : claimObj.Id.Value;
                claim.ClaimTypeId = claimObj.ClaimTypeId;
                claim.ClaimTitle = claimObj.ClaimTitle;
                claim.ClaimManager = claimObj.ClaimManager == null ? "" : claimObj.ClaimManager;
                // claim user info
                claim.ClaimUserDetails = new ClaimUserDetails();
                claim.ClaimUserDetails.FirstName = claimObj.FirstName;
                claim.ClaimUserDetails.LastName = claimObj.LastName;
                claim.ClaimUserDetails.Email = claimObj.Email;
                claim.ClaimUserDetails.CellPhoneNo = claimObj.CellPhoneNo;
                claim.ClaimUserDetails.HouseNo = claimObj.HouseNo;
                claim.ClaimUserDetails.StreetName = claimObj.StreetName;
                claim.ClaimUserDetails.Pincode = claimObj.Pincode;
                claim.ClaimUserDetails.City = claimObj.City;
                claim.ClaimUserDetails.StateId = claimObj.StateId;
                claim.ClaimUserDetails.CountryId = claimObj.CountryId;
                claim.ClaimUserDetails.Id = claimObj.UserId == null ? 0 : claimObj.UserId.Value;
                //claim vehicle info
                claim.ClaimVehicleDetails = new ClaimVehicleDetails();
                claim.ClaimVehicleDetails.VehicleFIN = claimObj.VehicleFIN;
                claim.ClaimVehicleDetails.Id = claimObj.VehicleId == null ? 0 : claimObj.VehicleId.Value;
                claim.ClaimVehicleDetails.ManufacturerId = claimObj.ManufacturerId;
                claim.ClaimVehicleDetails.ModelId = claimObj.ModelId;
                claim.ClaimVehicleDetails.ManufacturingDate = claimObj.ManufacturingDate;
                claim.ClaimVehicleDetails.DateOfPurchase = claimObj.DateOfPurchase;
                claim.ClaimVehicleDetails.PurchasePrise = claimObj.PurchasePrise;
                claim.ClaimVehicleDetails.KilometersDriven = claimObj.KilometersDriven;

                isUpdated = dllObj.UpdateClaim(claim);
                return isUpdated;
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
