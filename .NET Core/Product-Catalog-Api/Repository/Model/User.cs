using System.ComponentModel.DataAnnotations;

namespace Product_Catalog_Api.Repository.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string HashedPassword { get; set; }

        public string Role {  get; set; }
    }
}
