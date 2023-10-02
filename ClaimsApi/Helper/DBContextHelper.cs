using ClaimsApi.DLL;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ClaimsApi.Helper
{
    public static class DBContextHelper
    {
        public static DbContextOptions<ClaimsContext> GetDbContextOptions() { 
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return new DbContextOptionsBuilder<ClaimsContext>()
                .UseSqlServer(new SqlConnection(configuration.GetConnectionString("ClaimsDB"))).Options;
        }
    }
}
