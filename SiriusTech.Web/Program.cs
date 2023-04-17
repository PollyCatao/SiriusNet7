using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.WSIdentity;
using Microsoft.IdentityModel.Tokens;
using SiriusTech.Data.Context;
using SiriusTech.Data.Interfaces.Services;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add ConectionString with the Database
builder.Services.AddDbContext<SiriusTechContext>(options => options.UseSqlServer("Homologacao"));

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Scoped
builder.Services.AddScoped<ITokenServices, TokenService>();

// Add Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters =
    new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new
        SymmetricSecurityKey(Encoding.UTF8.
        GetBytes(configuration["chaveSecreta"])),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

// Add Authorization
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

    // 
    app.UseBrowserLink();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
