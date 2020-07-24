using Microsoft.AspNetCore.Mvc;
using productManagementApiTest.DataModels;
using productManagementApiTest.Service;
using System;

namespace productManagementApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var products = _productService.GetAllProduct();
                return Ok(products);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            try
            {
                var products = _productService.GetProduct(id);
                if (products == null)
                    return NotFound();
                return Ok(products);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST: api/Product
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            try
            {
                _productService.Insert(product);
                return Ok("Product has been added Successfully");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // PUT: api/Product
        [HttpPut]
        public ActionResult Put([FromBody] Product product)
        {
            try
            {
                _productService.Update(product);
                return Ok("Product has been updated Successfully");
            }
            catch (Exception)
            {
                    
                throw;
            }

        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _productService.Delete(id);
                return Ok("Product has been deleted Successfully");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
