using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Net;

namespace RealEstate.Pages
{
    public class Restaurant
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        [BsonElement("restaurant_id")]
        public string RestaurantId { get; set; }
        public string Cuisine { get; set; }
    }
}
