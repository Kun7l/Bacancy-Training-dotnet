using Mapster;
using Microsoft.AspNetCore.Mvc;
using Product_Catalog_Api.Controllers.DTO;
using Product_Catalog_Api.Repository.Interface;
using Product_Catalog_Api.Repository.Model;


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
            var products = await _productRepository.GetAllProducts();
            var productList = products.Adapt<List<ProductDTO>>();
           
            if (productList == null || productList.Count == 0)
            {
                return NotFound("Product not found");
            }
            else
            {
                return Ok(productList);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetWithId(int id)
        {
            var product = await _productRepository.GetProductWithId(id);
            var dto = product.Adapt<ProductDTO>();
            if (product == null)
            {
                return NotFound("Product not found");
            }
            else
            {
                return Ok(dto);
            }
        }

        [HttpGet("catagory/{catagory}")]
        public async Task<ActionResult> GetWithCatagory(string catagory)
        {
            var product = await _productRepository.GetProductsWithCatagoryNames(catagory);
            if (product == null)
            {
                return NotFound($"No products found for catagory : {catagory}");
            }
            else
            {
                return Ok(product);
            }
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct(ProductDTO product)
            
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(product);
            }
            await _productRepository.AddProduct(product);
            return Ok(product);
        }

        [HttpPatch("update/{id}")]
        public async Task<ActionResult> UpdateProduct(int id,ProductDTO product)
        {
            if (await _productRepository.UpdateProductAsync(id,product))
            {
                return NotFound("Not found");
            }

            return Ok("Updated");
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteProduct(int id) {

            if (await _productRepository.DeleteProduct(id))
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
