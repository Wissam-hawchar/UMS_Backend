using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS_BLL.DTO.Users;
using UMS_BLL.Services.GenericServices;
using UMS_BLL.Wrapping;
using UMS_DAL.Repositries._GenericRepository;
using UMS_DAL.Repositries.Users;

namespace UMS_BLL.Services.Users
{
    using Entity = UMS_DAL.Models.User;
    using Dto = UMS_BLL.DTO.Users.UserDTO;
    public class UserService : GenericService<Entity, Dto>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public override APIResponse<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override APIResponse<bool> Delete(Dto dto)
        {
            throw new NotImplementedException();
        }

    }
}
