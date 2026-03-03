using Event_Management_System.Repository.Model;
using Event_Management_System.Services.DTO;
using Event_Management_System.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using System.Security.Claims;

namespace Event_Management_System.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController(IEventServices _services) : ControllerBase
    {
        [HttpPost("create")]
        [Authorize(Roles ="admin,organizer")]
        public async Task<ActionResult<Event>> CreateEvent(EventDTO request)
        {
            int userId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var @event = await _services.CreateEvent(request,userId);
            if (@event == null)
            {
                
                return BadRequest("Already exits");
            }

            return Ok(@event);

        }

        [HttpPut("update")]
        [Authorize(Roles ="admin,organizer")]
        public async Task<ActionResult<Event>> UpdateEvent(EventUpdateDTO request)
        {
            string userName = User.FindFirstValue("username")!;

            var @event = await _services.UpdateEvent(request,userName);
            if(@event == null)
            {
                return BadRequest("Event doesnt exists or you are not authorized to update event");
            }
            return Ok(@event);
        }


    }
}
