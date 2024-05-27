using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Users;
using UMS_BLL.Wrapping;

namespace UMS_BLL.Services.Auth
{
    public interface IAuthService
    {
        APIResponse<bool> Login(string username, string password);
        APIResponse<bool> Login(LoginRequestDto loginRequestDto);
    }
}
