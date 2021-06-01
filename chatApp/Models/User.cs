using System.Collections;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace chatApp.Models
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        
    }
}