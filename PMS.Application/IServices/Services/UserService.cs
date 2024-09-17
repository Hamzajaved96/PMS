using PMS.Application.DTOs;
using PMS.Application.IServices;
using PMS.Domain.Entities;
using PMS.Presistance.Reposotries.IRepsoitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Application.IServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<int> CreateUserAsync(CreateUserDTO createUserDto)
        {
            User user = new User();
            user.UserName = createUserDto.UserName;
            user.Password = createUserDto.Password;
            var result = await _userRepository.AddAsync(user);
            return result;
        }
    }
}
