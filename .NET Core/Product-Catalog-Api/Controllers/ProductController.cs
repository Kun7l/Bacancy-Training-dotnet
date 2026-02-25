using Microsoft.AspNetCore.Mvc;
using Product_Catalog_Api.Repository.Interface;
using Product_Catalog_Api.Repository.Model;
using Product_Catalog_Api.Services;

namespace Product_Catalog_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult> Getall()
        {
            var products = _productRepository.GetAllProducts();
            if (products == null || products.Count == 0)
            {
                return NotFound("Product not found");
            }
            else
            {
                return Ok(products);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetWithId(int id)
        {
            var product = _productRepository.GetProductWithId(id);
            if (product == null)
            {
                return NotFound("Product not found");
            }
            else
            {
                return Ok(product);
            }
        }

        [HttpGet("catagory/{catagory}")]
        public async Task<ActionResult> GetWithCatagory(string catagory)
        {
            var product = _productRepository.GetProductsWithCatagoryNames(catagory);
            if (product == null || product.Count == 0)
            {
                return NotFound($"No products found for catagory : {catagory}");
            }
            else
            {
                return Ok(product);
            }
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return Ok(product);
        }

        [HttpPost("update")]
        public IActionResult UpdateProduct(Product product) { 
            bool res = _productRepository.UpdateProduct(product);

            if (!res)
            {
               return NotFound("Not found");
            }

           return Ok("Updated");
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteProduct(int id) {

            if (_productRepository.DeleteProduct(id))
            {
                return Ok("Deleted");
            }
            else
            {
                return NotFound("Not found");
            }

        }
    }
}
