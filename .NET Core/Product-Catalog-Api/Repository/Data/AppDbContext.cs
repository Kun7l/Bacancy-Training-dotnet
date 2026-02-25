using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Repository.Data
{
    public class AppDbContext 
    {
        public List<Product> products;

        public AppDbContext() { 
            products = new List<Product>
                                        {
                                            new Product { Id = 1, Name = "Wireless Mouse", Catagory = "Electronics" },
                                            new Product { Id = 2, Name = "Mechanical Keyboard", Catagory = "Electronics" },
                                            new Product { Id = 3, Name = "Ergonomic Office Chair", Catagory = "Furniture" },
                                            new Product { Id = 4, Name = "Standing Desk", Catagory = "Furniture" },
                                            new Product { Id = 5, Name = "Noise Cancelling Headphones", Catagory = "Audio" },
                                            new Product { Id = 6, Name = "Bluetooth Speaker", Catagory = "Audio" },
                                            new Product { Id = 7, Name = "Running Shoes", Catagory = "Apparel" },
                                            new Product { Id = 8, Name = "Cotton T-Shirt", Catagory = "Apparel" },
                                            new Product { Id = 9, Name = "Stainless Steel Water Bottle", Catagory = "Kitchen" },
                                            new Product { Id = 10, Name = "Ceramic Coffee Mug", Catagory = "Kitchen" }
                                        };
        }
    }
}
