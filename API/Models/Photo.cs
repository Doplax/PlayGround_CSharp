using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.Models;

public class Photo
{
    [BsonElement("data")]
    public byte[] Data { get; set; } = null!;

    [BsonElement("contentType")]
    public string ContentType { get; set; } = null!;
}
