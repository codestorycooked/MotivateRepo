using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotivateMeAPI.DataAccess.Models
{
    public class Thoughts
    {
        [BsonId]
        public string Id { get; set; }
        public string Thought { get; set; }
        public string CategoryID { get; set; }
        public string Views { get; set; }
        public string Shares { get; set; }
    }
}
