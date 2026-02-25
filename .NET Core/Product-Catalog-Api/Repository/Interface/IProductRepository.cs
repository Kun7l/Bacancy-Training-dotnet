using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Repository.Interface
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
        public Product GetProductWithId(int id);

        public List<Product> GetProductsWithCatagoryNames(string catagory);

        public void AddProduct(Product product);

        public bool UpdateProduct(Product product);

        public bool DeleteProduct(int id);
        
    }
}
