using PMS.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Application.IServices
{
    public interface IUserService
    {
        Task<int> CreateUserAsync(CreateUserDTO createUserDto);

    }
}
