using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIStock.Data.Collections
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        [BsonElement("name")]
        public string? Name { get; set; }
        [BsonElement("description")]
        public string? Description { get; set; }
        [BsonElement("price")]
        public double Price { get; set; }
        [BsonElement("categorya_id")]
        public string? Category { get; set; }
        [BsonElement("supplier_id")]
        public string? Supplier { get; set; }
        [BsonElement("current_inventory")]
        public int CurrentInventory { get; set; }
        [BsonElement("created_at")]
        public DateTime Created_at { get; set; }
        [BsonElement("updated_at")]
        public DateTime Updated_at { get; set; }
    }
}
