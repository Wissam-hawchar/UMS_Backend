using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS_BLL.DTO.Users
{
    public class LoginRequestDto
    {
        public string? Username { get; set; }

        public string? Password { get; set; }
    }
}
