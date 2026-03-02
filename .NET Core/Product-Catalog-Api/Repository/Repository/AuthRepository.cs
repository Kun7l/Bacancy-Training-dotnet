using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Product_Catalog_Api.Controllers.DTO;
using Product_Catalog_Api.Repository.Data;
using Product_Catalog_Api.Repository.Interface;
using Product_Catalog_Api.Repository.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Product_Catalog_Api.Repository.Repository
{
    public class AuthRepository(AppDbContext _context,IConfiguration configuration) : IAuthRepository
    {
        public async Task<string?> LoginUser(UserDTO request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u=>u.UserName == request.UserName);
            if (user == null)
            {
                return null;
            }
            if (new PasswordHasher<User>().VerifyHashedPassword(user,user.HashedPassword,request.Password) == PasswordVerificationResult.Failed)
            {
                return null;   
            }
            
            return CreateToken(user);
        }

        public async Task<User?> RegisterUser(UserDTO request)
        {
            if (await _context.Users.AnyAsync(u=>u.UserName == request.UserName) )
            {
                return null;   
            }
            User user = new User();
            string hashedPassword = new PasswordHasher<User>().HashPassword(user, request.Password);
            user.HashedPassword = hashedPassword;
            user.UserName = request.UserName;
            user.Role = request.Role;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserName),
                new Claim(ClaimTypes.Role,user.Role)
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(configuration.GetValue<string>("Appsettings:Token")!)
                );

            var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new JwtSecurityToken(
                issuer: configuration.GetValue<string>("Appsettings:Issuer"),
                audience: configuration.GetValue<string>("Appsettings:Audience"),
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}
