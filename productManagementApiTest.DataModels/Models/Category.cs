using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace productManagementApiTest.DataModels
{
    public class Category
    {
        [BsonElement("_id")]
         
      
        public int categoryId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public Category SubCategory { get; set; }
    }
}
