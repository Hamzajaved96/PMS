using PMS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Presistance.Reposotries.IRepsoitory
{
    public interface IUserRepository
    {
        Task<int> AddAsync(User user);

    }
}
