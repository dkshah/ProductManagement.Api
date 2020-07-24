using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace productManagementApiTest.DataModels
{
    public class ProductManagementUnitOfWork
    {
        private readonly MongoDatabase _database;
        protected ProductManagementRepository<Product> _product;
        public ProductManagementUnitOfWork(IConfiguration configuration)
        {
            var connectionString = configuration["MongoDBConectionString"];
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var databaseName = configuration["MongoDBDatabaseName"];
            _database = server.GetDatabase(databaseName);
        }
        public ProductManagementRepository<Product> Products
        {
            get
            {
                if (_product == null) _product = new ProductManagementRepository<Product>(_database, "products");
                return _product;
            }
        }
    }
}
