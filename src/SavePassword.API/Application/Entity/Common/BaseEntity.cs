using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace SavePassword.API.Application.Entity.Common
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdateAt { get; set; }
        public bool Deleted { get; private set; } = false;

        public void Delete()
        {
            Deleted = true;
            UpdateAt = DateTime.Now;
        }
    }
}
