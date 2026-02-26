using Product_Catalog_Api.Controllers.DTO;
using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Repository.Interface
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllProducts();
        public Task<Product?> GetProductWithId(int id);

        public Task<List<Product>> GetProductsWithCatagoryNames(string catagory);

        public Task AddProduct(ProductDTO product);

        public Task<bool> UpdateProductAsync(int id,ProductDTO product);

        public Task<bool> DeleteProduct(int id);
        
    }
}
