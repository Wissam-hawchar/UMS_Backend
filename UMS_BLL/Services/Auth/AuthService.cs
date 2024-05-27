using AutoMapper;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Users;
using UMS_BLL.Wrapping;
using UMS_DAL.Repositries.Users;

namespace UMS_BLL.Services.Auth
{
    public class AuthService:IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public AuthService(IUserRepository userRepository, IMapper mapper) 
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public APIResponse<bool> Login(string username, string password)
        {
            var response = new APIResponse<bool>();
            var user = _userRepository.GetUserByUsername(username);
            if (user.Username == username && user.Password == password)
            {
                response.Success = true;
                return response;
            }
            response.Success = false;
            return response;
        }

        public APIResponse<bool> Login(LoginRequestDto loginRequestDto)
        {
            var user = _userRepository.GetUserByUsername(loginRequestDto.Username);
            if (user == null)
            {
                throw new Exception("Username not found");
            }
            if (user.Password != loginRequestDto.Password)
            {
                throw new Exception("wrong password");
            }
            return new APIResponse<bool>(true);
        }
    }
}
