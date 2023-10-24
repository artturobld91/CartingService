using MongoDB.Bson.Serialization.Attributes;

namespace CartingService.DAL.Models
{
    public sealed class Item
    {
        [BsonId] // Specifies a field that must be unique
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        [BsonElement("money")]
        public decimal Money { get; set; } = decimal.Zero;

        [BsonElement("quantity")]
        public int Quantity { get; set; } = 0;

        [BsonElement("image")]
        public string Image { get; set; } = string.Empty;
    }
}
