using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.Auth;
using UMS_BLL.Services.Users;
using UMS_BLL.Wrapping;

namespace UMS_WebAPI_NEW.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService) 
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public APIResponse<bool> Login(LoginRequestDto loginRequest)
        {
            //_userService.Login(loginRequest.Username, loginRequest.Password);
            return _authService.Login(loginRequest);
        }
    }
}
