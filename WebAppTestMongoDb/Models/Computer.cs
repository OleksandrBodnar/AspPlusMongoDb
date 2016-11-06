using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppTestMongoDb.Models
{
    public class Computer
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Display(Name = "Название модели")]
        public string Name { get; set; }
        [Display(Name = "Год выпуска")]
        public int Year { get; set; }
        public string ImageId { get; set; }
        public bool HasImage()
        {
            return !String.IsNullOrWhiteSpace(ImageId);
        }
    }
}