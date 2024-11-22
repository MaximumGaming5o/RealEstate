using MongoDB.Driver;
using MongoDB.Bson;
using RealEstate.Models;
using RealEstate.Services;


DataService dataService = new DataService();

dataService.PingDatabase();
dataService.InitUserSystem();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages()
    .AddRazorPagesOptions(options =>
    {
        options.Conventions.AddPageRoute("/Index/Index", "");
        options.Conventions.AddPageRoute("/AccountDetails/AccountDetails", "AccountDetails");
        options.Conventions.AddPageRoute("/PropertyListings/PropertyListings", "PropertyListings");
        options.Conventions.AddPageRoute("/Error/Error", "Error");
        options.Conventions.AddPageRoute("/Privacy/Privacy", "Privacy");
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
