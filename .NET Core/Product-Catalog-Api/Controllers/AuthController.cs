using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Product_Catalog_Api.Controllers.DTO;
using Product_Catalog_Api.Repository.Interface;
using Product_Catalog_Api.Repository.Model;

namespace Product_Catalog_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthRepository repository) : ControllerBase
    {
        public static User user = new User();

        [HttpPost("register")]
        public async Task<ActionResult<User>> RegisterUser(UserDTO request)
        {
            var user = await repository.RegisterUser(request);
            if (user == null) {
                return BadRequest("User already exits.");
            }

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginUser(UserDTO request)
        {
           var response = await repository.LoginUser(request);

            if (response == null) {
                return BadRequest("Invalid username or password.");
            }
            return Ok(response);
        }

        [HttpGet("vendor")]
        [Authorize(Roles = "vendor")]
        public IActionResult getVendor()
        {
            return Ok("Vendor only can access");
        }

        [HttpGet("admin-vendor")]
        [Authorize(Roles = "admin,vendor")]
        public IActionResult getAdminAndVendor()
        {
            return Ok("Admin and vendor can access");
        }

        [HttpGet("admin")]
        [Authorize(Roles = "admin")]
        public IActionResult getAdmin()
        {
            return Ok("Admin only can access");
        }
    }
}
