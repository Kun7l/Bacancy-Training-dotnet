using Microsoft.AspNetCore.Identity;
using Product_Catalog_Api.Controllers.DTO;
using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Repository.Interface
{
    public interface IAuthRepository
    {
        public Task<User?> RegisterUser(UserDTO request);

        public Task<string?> LoginUser(UserDTO request);
        
    }
}
