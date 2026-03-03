using Event_Management_System.Repository.Model;
using Event_Management_System.Services.DTO;
using Event_Management_System.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserServices _services) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<User>> RegisterUser(UserRegisterDTO request) {
            var user = await _services.RegisterUser(request);

            if (user == null)
            {
                return BadRequest("User already exits.");
            }

            return Ok(user);
        }

        [HttpPost("register-organizer")]
        public async Task<ActionResult<User>> RegisterOrganizer(UserRegisterDTO request)
        {
            var user = await _services.RegisterOrganizer(request);

            if (user == null)
            {
                return BadRequest("User already exits.");
            }

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> LoginUser(UserRegisterDTO request)
        {
            var token = await _services.Login(request);

            if (token == null)
            {
                return BadRequest("Invalid username or password.");
            }

            return Ok(token);
        }

        [HttpDelete("delete-user")]
        public async Task<ActionResult<string>> DeleteUser(string userName) { 
            bool response = await _services.DeleteUser(userName);
            if (!response) {
                return BadRequest("User does not exits");
            }

            return Ok("Succefully deleted.");
        }
    }
}
