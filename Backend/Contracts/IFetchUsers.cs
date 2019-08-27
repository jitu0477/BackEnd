using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Contracts
{
    public interface IFetchUsers
    {
        Task<IList<User>> GetUsers();
    }
}
