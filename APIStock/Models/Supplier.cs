using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace APIStock.Models
{
    public class Supplier
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("contact")]
        public Contact Contact { get; set; }

        [BsonElement("address")]
        public Address Address { get; set; }
    }

    public class Contact
    {
        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }
    }

    public class Address
    {
        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("number")]
        public int Number { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("state")]
        public string State { get; set; }

        [BsonElement("zip_code")]
        public string ZipCode { get; set; }
    }
}
