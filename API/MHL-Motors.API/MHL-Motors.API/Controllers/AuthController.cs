using MHL_Motors.Models;
using MHL_Motors.Models.DTOs;
using MHL_Motors.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MHL_Motors.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUser _user;
        

        public AuthController(IUser user)
        {
            _user = user;
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> Register(RegisterUserDto registerUserDTO)
        {
            var result = await _user.RegisterUserAsync(registerUserDTO);

            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<ActionResult<LoginResponse>> Login(LoginUserDto loginUserDTO)
        {
            var result = await _user.LoginUserAsync(loginUserDTO);

            return Ok(result);
        }
    }
}
