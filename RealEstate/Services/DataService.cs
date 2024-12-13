using MongoDB.Bson;
using MongoDB.Driver;
using RealEstate.Models;

namespace RealEstate.Services;

public class DataService
{
    //Create a link to MongoDB
    public const string ConnectionUri =
        "mongodb+srv://AdamZ:xT83uhvWICmqumdr@realestate.kx91f.mongodb.net/?retryWrites=true&w=majority&appName=RealEstate";

    private readonly MongoClient _mongoClient;
    private IMongoDatabase? _myDb;

    public MongoClientSettings Settings = MongoClientSettings.FromConnectionString(ConnectionUri);

    List<User> _userList = new List<User>();


    private IMongoCollection<User> userCollection;

    public DataService()
    {
        Settings.ServerApi = new ServerApi(ServerApiVersion.V1);
        _mongoClient = new MongoClient(Settings);
        _myDb = _mongoClient.GetDatabase("real_estate");
    }

    public void PingDatabase()
    {
        try
        {
            var result = _mongoClient.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
            Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

        IMongoDatabase? GetMyDb() { return _myDb; }

        //Get the sample database with sample data for testing

        //Create a list of collections on the database
        List<string> GetCollections(IMongoDatabase? _myDb)
        {
            var collections = new List<string>();

            for (int i = 0; i < _myDb?.ListCollectionsAsync().Result.ToListAsync().Result.Count; i++)
            {
                BsonDocument? collection = _myDb.ListCollectionsAsync().Result.ToListAsync<BsonDocument>().Result[i];
                var name = collection["name"].AsString;
                collections.Add(name);
            }

            return collections;
        }

        //Print list of collections
        Console.WriteLine("Collections in database:");
        for (var i = 0; i < GetCollections(GetMyDb()).Count; i++) Console.WriteLine(GetCollections(GetMyDb())[i]);
    }

    public void InitUserSystem()
    {
        _userList = new List<User>();

        var userNumOne = new User(12345, "Adam", "Zyluk", "adam.zyluk.az@test.com",
            "Password123", "123-456-7890", "123 Test St.", UserType.Seller);

        _userList.Add(userNumOne);

        userCollection = _myDb?.GetCollection<User>("users");

        userCollection?.InsertOne(userNumOne);
    }

    public User SearchUserByEmail(string email)
    {
        User searchedUser = null;

       searchedUser = userCollection.Find(User => User.Email == email).FirstOrDefault();

        return searchedUser;
    }
}