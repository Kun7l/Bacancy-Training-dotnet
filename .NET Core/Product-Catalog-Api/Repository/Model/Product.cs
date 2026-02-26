using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_Catalog_Api.Repository.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        public string Catagory { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
