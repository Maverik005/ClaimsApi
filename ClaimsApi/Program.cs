using ClaimsApi.DLL;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using ClaimsApi.BLL;
using ClaimsApi.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ClaimsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ClaimsDB")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddSingleton<IConfigDataBll,ConfigDataBll>();
builder.Services.AddSingleton<IClaimBll,ClaimBll>();
var app = builder.Build();

app.UseSwagger();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}
app.UseCors(options =>
{
    options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
});
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
