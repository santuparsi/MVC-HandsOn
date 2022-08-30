using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingEFCore.Models;
namespace HandsOnMVCUsingEFCore.Repositories
{
   public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(string uname);
        void Add(User item);
        void Update(User item);
        void Delete(User item);
    }
}
