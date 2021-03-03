using System;
using Interview.CartCase.Domain.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Interview.CartCase.Domain.Entities
{
    public abstract class MongoBaseEntity : IEntity<string>
    {
        [BsonId]
        [BsonElement(Order = 0)]
        public string Id { get; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public string Creator { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime Modified { get; set; }
        public string Modifier { get; set; }
        public bool IsActive { get; set; }
    }
}