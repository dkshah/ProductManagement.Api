using productManagementApiTest.DataModels;
using System.Linq;

namespace productManagementApiTest.Service
{
    public interface IProductService
    {
        void Insert(Product product);
        void Update(Product product);
        void Delete(int productId);

        IQueryable<Product> GetAllProduct();

        Product GetProduct(int productId);
    }
}
