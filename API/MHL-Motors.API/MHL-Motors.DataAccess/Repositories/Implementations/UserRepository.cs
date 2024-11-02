using BCrypt.Net;
using MHL_Motors.DataAccess.DatabaseContext;
using MHL_Motors.Models;
using MHL_Motors.Models.DTOs;
using MHL_Motors.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MHL_Motors.DataAccess.Repositories.Implementations
{
    public class UserRepository : IUser
    {
        private readonly DataContext _dataContext;
        private readonly IConfiguration _configuration;

        public UserRepository(DataContext dataContext, IConfiguration configuration)
        {
            _dataContext = dataContext;
            _configuration = configuration;
        }

        public async Task<LoginResponse> LoginUserAsync(LoginUserDto loginUserDTO)
        {
            var user = await _dataContext.Users.FirstOrDefaultAsync(u => u.Email == loginUserDTO.Email);

            if(user == null )
            {
                return new LoginResponse(false, "User not found");
            }

            bool checkPassword = BCrypt.Net.BCrypt.Verify(loginUserDTO.Password, user.Password);

            if(checkPassword) 
            {
                return new LoginResponse(true, "Login successfully", CreateToken(user));
            }

            return new LoginResponse(false, "Invalid credentials");
        }

        public async Task<RegistrationResponse> RegisterUserAsync(RegisterUserDto registerUserDTO)
        {
            var user = await _dataContext.Users.FirstOrDefaultAsync(u => u.Email == registerUserDTO.Email);

            if (user != null)
            {
                return new RegistrationResponse(false, "User already exists");
            }
            else
            {
                _dataContext.Users.Add(new Models.User() {
                    UserName = registerUserDTO.UserName,
                    Email = registerUserDTO.Email,
                    Password = BCrypt.Net.BCrypt.HashPassword(registerUserDTO.Password)
                });

                await _dataContext.SaveChangesAsync();
                return new RegistrationResponse(true, "Registration completed");
            }
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, "userRole"),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
