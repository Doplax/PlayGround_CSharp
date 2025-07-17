using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Models;

public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;

    [BsonElement("name")]
    [BsonRequired]
    public string Name { get; set; } = null!;

    [BsonElement("price")]
    [BsonRequired]
    [BsonRepresentation(BsonType.Double)]
    public double Price { get; set; }

    [BsonElement("isForSale")]
    public bool IsForSale { get; set; } = true;

    [BsonElement("photo")]
    public Photo? Photo { get; set; }

    [BsonElement("tags")]
    public List<string> Tags { get; set; } = new();
}
