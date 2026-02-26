using Mapster;
using System.ComponentModel.DataAnnotations;

namespace Product_Catalog_Api.Controllers.DTO
{
    public class ProductDTO
    {
        [StringLength(10)]
        public string Name { get; set; } 
        public string Catagory { get; set; }
    }
}
