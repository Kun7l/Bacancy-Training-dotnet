using Event_Management_System.Repository.Interface;
using Event_Management_System.Repository.Model;
using Event_Management_System.Services.DTO;
using Event_Management_System.Services.Interface;
using Mapster;
using static Event_Management_System.Repository.Enums.Roles;

namespace Event_Management_System.Services
{
    public class EventServices(IEventRepository _repository,IUserRepository _userRepo) : IEventServices
    {
        public async Task<Event?> CreateEvent(EventDTO eventDetails,int userId)
        {
            
            Event newEvent = eventDetails.Adapt<Event>();
            newEvent.CreatedBy = userId;

            var @event = await _repository.CreateEvent(newEvent);

            if (@event == null)
            {
                return null;
            }

            return @event;
        }

        public async Task<Event?> UpdateEvent(EventUpdateDTO eventDetails, string userName)
        {
            var @event = await _repository.ViewEventByName(eventDetails.Name);
            var user = await _userRepo.GetUserWithUserName(userName);

            if (@event == null) {
                return null;
            }
            if (user.Role != UserRole.admin && user.Id != @event.CreatedBy ) {
                return null;
            }


            return await _repository.UpdateEvent(eventDetails);
        }
    }
}
