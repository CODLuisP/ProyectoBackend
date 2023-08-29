using Microsoft.AspNetCore.Authentication.Cookies;
using MySql.Data.MySqlClient;
using System.Data;
using VelSatBackend.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(option =>
{
    option.LoginPath = "/Access/Login";
    option.ExpireTimeSpan = TimeSpan.FromMinutes(20);
});

// Configuración de la inyección de dependencias
builder.Services.AddTransient<IDbConnection>((sp) =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    string connectionString = configuration.GetConnectionString("DefaultConnection");
    return new MySqlConnection(connectionString);
});

// Agregar el repositorio a la inyección de dependencias
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<DA_Logica>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Acceso}/{action=Index}/{id?}");

app.Run();
