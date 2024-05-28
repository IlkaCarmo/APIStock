using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIStock.Models
{
    public class StockMovement
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("product_id")]
        public string ProductId { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [BsonElement("movement_type")]
        public string MovementType { get; set; } // "entry" or "exit"

        [BsonElement("movement_date")]
        public DateTime MovementDate { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
