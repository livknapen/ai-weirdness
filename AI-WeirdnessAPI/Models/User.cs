using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AI_WeirdnessAPI.Models
{
    [BsonIgnoreExtraElements] //Ignore extra fields from MongoDB.
	public class User
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        //public string Auth0ID { get; set; } = null!;

        [BsonElement("username")]
        public string Username { get; set; } = null!;

        [BsonElement("score")]
        public int Score { get; set; } = 0!;

        [BsonElement("vote")]
        public Vote Vote { get; set; } = Vote.None;

    }

    public enum Vote
    {
        None,
        AI,
        Human
    }
}
