using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotivateMeAPI.DataAccess.Models
{
    public class Categories
    {
        [BsonId]
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryPicture { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
