using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIStock.Models
{
    public class CategoryDto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
