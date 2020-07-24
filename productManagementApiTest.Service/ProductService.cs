using Microsoft.Extensions.Configuration;
using productManagementApiTest.DataModels;
using System.Linq;

namespace productManagementApiTest.Service
{
    public class ProductService : IProductService
    {
        private readonly ProductManagementUnitOfWork _unitOfWork;

        public ProductService(IConfiguration configuration)
        {
            _unitOfWork = new ProductManagementUnitOfWork(configuration);
        }
        public void Delete(int productId)
        {
            _unitOfWork.Products.Delete(p => p.productId, productId);
        }

        public IQueryable<Product> GetAllProduct()
        {
            return _unitOfWork.Products.GetAll();
        }

        public Product GetProduct(int productId)
        {
            return _unitOfWork.Products.Get(productId);
        }

        public void Insert(Product product)
        {
            _unitOfWork.Products.Add(product);
        }

        public void Update(Product product)
        {
            _unitOfWork.Products.Update(p => p.productId, product.productId, product);
        }
    }
}
