using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1
{
    public class User
    {
        [BsonElement("_id")]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("username")]
        public string Username { get; set; }
        
        [BsonElement("age")]
        public int Age { get; set; }
    }
}