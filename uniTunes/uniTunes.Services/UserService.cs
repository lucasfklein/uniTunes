using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models.Models;

namespace uniTunes.Services
{
    public interface IUserService
    {
        Academic GetUser(int id);
        IEnumerable<Academic> GetUsers();
        IEnumerable<Academic> GetUsers(string username);
    }

    public class UserService : IUserService
    {
           
        public Academic GetUser(int id)
        {
            return new Academic();
        }

        public IEnumerable<Academic> GetUsers()
        {
            return new List<Academic>(){};
        }

        public IEnumerable<Academic> GetUsers(string username)
        {
            return new List<Academic>() { };
        }

    }
}
