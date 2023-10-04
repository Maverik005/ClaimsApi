using System.Security.Claims;

namespace ClaimsApi.Helper
{
    public static class ClaimsHelper
    {
        public static string GetLoggedInUserEmail(ClaimsPrincipal principal)
        {
            try
            {
                string userEmail = string.Empty;
                userEmail = principal.FindFirstValue(ClaimTypes.Email).ToString();
                return userEmail;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
