using Domain.Entities;
using Infrastructure.Services;
using WebUI.Components;
using Microsoft.Extensions.DependencyInjection;
using WebUI.Controllers;


var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

// Hämta ConnectionString
var connectionString = builder.Configuration.GetConnectionString("MovieHub1");
Console.WriteLine($"ConnectionString: {connectionString}");
Console.WriteLine($"Running environment: {builder.Environment.EnvironmentName}");

// Lägg till MySettings-tjänsten i DI-container
builder.Services.Configure<MySettings>(builder.Configuration.GetSection("ConnectionStrings"));


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

var db = new MovieHubContext(connectionString);

// Skapa en film och lägg till den i databasen
Movie movie = new Movie("Pulp Fiction", "Hahahaha", 200, 8);
        
// Lägg till filmen i MongoDB
db.Movies.InsertOne(movie);

Console.WriteLine("Filmen har lagts till i databasen.");



app.Run();



