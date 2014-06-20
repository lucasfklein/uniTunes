using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models;

namespace uniTunes.Services.Contracts
{
    public interface IAuthService
    {
        Academic GetAcademic(string login);
        Academic Auth(string login, string pass);
        void Register(Academic academic);
        void Unregister(Academic academic);
        bool RecoverPassword(string user);
        string GetSecretQuestion(string email);
    }
}
