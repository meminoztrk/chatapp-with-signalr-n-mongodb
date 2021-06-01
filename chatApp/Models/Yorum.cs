using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace chatApp.Models
{
    public class Yorum
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }

        public string yorumid { get; set; }
        public string yorums { get; set; }
        public string chatid { get; set; }
        public string userid { get; set; }
        public string adsoyad { get; set; }
    }
}