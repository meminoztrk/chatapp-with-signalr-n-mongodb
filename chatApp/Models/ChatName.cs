using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace chatApp.Models
{
    public class ChatName
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }

        public string chatid { get; set; }
        public string chatismi { get; set; }
    }
}