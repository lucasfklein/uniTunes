using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models;

namespace uniTunes.Services
{
    public interface IAuthService
    {
        Academic Auth(int id, string pass);
        bool Register(Academic academic);
        bool Unregister(Academic academic);
        bool RecoverPassword(string user);
    }

    public class AuthService : IAuthService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Academic Auth(int id, string pass)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="academic"></param>
        /// <returns></returns>
        public bool Register(Academic academic)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="academic"></param>
        /// <returns></returns>
        public bool Unregister(Academic academic)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool RecoverPassword(string user)
        {
            throw new NotImplementedException();
        }
    }
}
