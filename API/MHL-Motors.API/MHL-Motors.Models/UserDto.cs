using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHL_Motors.Models
{
    public class UserDto
    {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }
}
