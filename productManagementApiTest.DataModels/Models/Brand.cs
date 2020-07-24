using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace productManagementApiTest.DataModels
{
    public class Brand
    {
        [BsonElement("_id")]

        public int BrandId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
