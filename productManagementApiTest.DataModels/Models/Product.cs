using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace productManagementApiTest.DataModels
{
    public class Product
    {
        [BsonElement("_id")]

        public int productId { get; set; }
        public string Name { get; set; }

        public Brand Brand { get; set; }

        public double Price { get; set; }

        public Currancy currancy { get; set; }

        public double Height { get; set; }

        public string Color { get; set; }

        public double Weight { get; set; }

        public Category Category { get; set; }
    }
}
