using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Services
{
    public interface IProductServices 
    {
        public List<Product> GetAllProducts(int id);
    }
}
