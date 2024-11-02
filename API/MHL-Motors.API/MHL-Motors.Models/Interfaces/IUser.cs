using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHL_Motors.Models.DTOs;

namespace MHL_Motors.Models.Interfaces
{
    public interface IUser
    {
        Task<RegistrationResponse> RegisterUserAsync(RegisterUserDto registerUserDTO);
        Task<LoginResponse> LoginUserAsync(LoginUserDto loginUserDTO);
    }
}
