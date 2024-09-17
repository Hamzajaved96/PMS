using PMS.Domain.Entities;
using PMS.Presistance.Reposotries.IRepsoitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Presistance.Reposotries
{
    public class UserRepository : IUserRepository
    {
       
        public UserRepository()
        {
        }
        public Task<int> AddAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
