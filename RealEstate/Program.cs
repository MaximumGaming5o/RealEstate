using MongoDB.Driver;
using MongoDB.Bson;

//Create a link to MongoDB
const string connectionUri = "mongodb+srv://AdamZ:xT83uhvWICmqumdr@realestate.kx91f.mongodb.net/?retryWrites=true&w=majority&appName=RealEstate";
var settings = MongoClientSettings.FromConnectionString(connectionUri);
settings.ServerApi = new ServerApi(ServerApiVersion.V1);

// Create a new client and connect to the server
var mongoClient = new MongoClient(settings);

// Send a ping to confirm a successful connection
try
{
    var result = mongoClient.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
    Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

//Get the sample database with sample data for testing
var myDB = mongoClient.GetDatabase("sample_mflix");

//Create a list of collections on the database
List<string> GetCollections()
{
    List<string> collections = new List<string>();

    foreach (BsonDocument collection in myDB.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result)
    {
        string name = collection["name"].AsString;
        collections.Add(name);
    }

    return collections;
}

//Print list of collections
for (int i = 0; i < GetCollections().Count; i++)
{
    Console.WriteLine(GetCollections()[i]);
}










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
