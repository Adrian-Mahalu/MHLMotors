using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHL_Motors.Models.DTOs
{
    public record RegistrationResponse(bool Flag, string Message = null);
}
