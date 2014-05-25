using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models;

namespace uniTunes.Services
{
    public interface IAccountService
    {
        Account GetAccount(int id);
    }

    public class AccountService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Account GetAccount(int id)
        {
            throw new NotImplementedException();
        }
    }
}
