using Event_Management_System.Repository.Model;
using Event_Management_System.Services.DTO;

namespace Event_Management_System.Services.Interface
{
    public interface IEventServices 
    {
        public Task<Event?> CreateEvent(EventDTO eventDetails,int userId);

        public Task<Event?> UpdateEvent(EventUpdateDTO eventDetails,string userName); 
        
    }
}
