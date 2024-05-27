using Microsoft.AspNetCore.Mvc;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Services.Users;
using UMS_BLL.Wrapping;

namespace UMS_WebAPI_NEW.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : GenericController<UserDTO>
    {
        private readonly IUserService _userService;
        public UserController(IUserService genericService) : base(genericService)
        {
            _userService = genericService;
        }
        
    }
}
