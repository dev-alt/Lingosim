using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Lingosim;

public class Phrase
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("text")]
    public string Text { get; set; }

    [BsonElement("meaning")]
    public string Meaning { get; set; }

    [BsonElement("explanation")]
    public string Explanation { get; set; }

    [BsonElement("date")]
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime Date { get; set; }
}