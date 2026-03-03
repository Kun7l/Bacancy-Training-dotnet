using Event_Management_System.Repository.Data;
using Event_Management_System.Repository.Interface;
using Event_Management_System.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace Event_Management_System.Repository
{
    public class UserRepository(AppDbContext _context) : IUserRepository
    {
        public async Task<User?> Register(User user)
        {
            if (await _context.Users.AnyAsync(u => u.Id == user.Id)) {
                return null;
            }
            _context.Users.Add(user);
            await  _context.SaveChangesAsync();

            return user;
        }

        public async Task<User?> GetUserWithUserName(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u=>u.UserName == username);
        }

        public async Task DeleteUserWithUserName(string username)
        {
            var user = await _context.Users.FirstAsync(u=>u.UserName == username);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
