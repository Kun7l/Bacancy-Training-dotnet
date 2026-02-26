using Mapster;
using Microsoft.EntityFrameworkCore;
using Product_Catalog_Api.Controllers.DTO;
using Product_Catalog_Api.Repository.Data;
using Product_Catalog_Api.Repository.Interface;
using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Repository.Repository
{
    public class ProductRepository(AppDbContext _context) : IProductRepository
    {
        
        public async Task AddProduct(ProductDTO product)
        {
            var productWhole = product.Adapt<Product>();
            productWhole.CreatedDate = DateTime.Now;

            _context.Products.Add(productWhole);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if(product == null) return false;
            else
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<Product>> GetAllProducts()
        {
          return await _context.Products.ToListAsync();
        }

        public async Task<List<Product>> GetProductsWithCatagoryNames(string catagory)
        {
            return await _context.Products.Where(p=>p.Catagory == catagory).ToListAsync();
        }

        public async Task<Product?> GetProductWithId(int id)
        {
            var result =  _context.Products.FirstOrDefault(p => p.Id == id);
            return await Task.FromResult(result);
        }

        public async Task<bool> UpdateProductAsync(int id,ProductDTO product)
        {
            var productFromDb = _context.Products.FirstOrDefault(p=>p.Id == id);
            if(productFromDb == null)
            {
                return false;
            }
            productFromDb.Name = product.Name;
            productFromDb.Catagory = product.Catagory;  

            await _context.SaveChangesAsync();
            return true;

        }
    }
}
