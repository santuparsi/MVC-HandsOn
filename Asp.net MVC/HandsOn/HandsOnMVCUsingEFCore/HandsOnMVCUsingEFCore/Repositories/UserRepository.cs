using HandsOnMVCUsingEFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCUsingEFCore.Context;
namespace HandsOnMVCUsingEFCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private UserContext _context;
        public UserRepository(UserContext context)
        {
            _context = context;
        }
        public void Add(User item)
        {
            _context.Users.Add(item);
            _context.SaveChanges();
        }

        public void Delete(User item)
        {
            _context.Users.Remove(item);
            _context.SaveChanges();
        }

        public User GetUser(string uname)
        {
            return _context.Users.SingleOrDefault(item => item.Username == uname);
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void Update(User item)
        {
            _context.Users.Update(item);
            _context.SaveChanges();
        }
    }
}
