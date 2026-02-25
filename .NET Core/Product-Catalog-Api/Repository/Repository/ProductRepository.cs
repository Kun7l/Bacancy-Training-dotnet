using Product_Catalog_Api.Repository.Data;
using Product_Catalog_Api.Repository.Interface;
using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Repository.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context) {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.products.Add(product);
        }

        public List<Product> GetAllProducts()
        {
            return _context.products.ToList();
        }

        public List<Product> GetProductsWithCatagoryNames(string catagory)
        {
            return _context.products.Where(p=>p.Catagory == catagory).ToList();
        }

        public Product GetProductWithId(int id)
        {
            return _context.products.FirstOrDefault(p=>p.Id == id);
        }

        public bool UpdateProduct(Product product) {
           var result = _context.products.FirstOrDefault(p => p.Id == product.Id);
            if (result == null) {
                return false;
            }
            else
            {
                result.Name = product.Name;
                result.Catagory = product.Catagory;
                return true;
            }
        }

        public bool DeleteProduct(int id) { 
            var result = _context.products.FirstOrDefault(x => x.Id == id);
            if (result !=null)
            {
                _context.products.Remove(result);
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
