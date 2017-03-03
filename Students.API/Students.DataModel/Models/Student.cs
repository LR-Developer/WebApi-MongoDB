using MongoDB.Bson.Serialization.Attributes;

namespace Students.DataModel.Models
{
    public class Student
    {
        [BsonElement("_id")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Class { get; set; }
    }
}
