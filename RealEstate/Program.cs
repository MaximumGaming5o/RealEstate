var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages()
    .AddRazorPagesOptions(options =>
    {
        options.Conventions.AddPageRoute("/Home/Home", "/Index");
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
