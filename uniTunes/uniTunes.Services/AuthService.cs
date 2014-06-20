using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Data.Infrastructure;
using uniTunes.Data.Repositories;
using uniTunes.Models;
using uniTunes.Services.Contracts;

namespace uniTunes.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAcademicRepository academicRepository;
        private readonly IUnitOfWork unitOfWork;

        public AuthService(IAcademicRepository academicRepository, IUnitOfWork unitOfWork)
        {
            this.academicRepository = academicRepository;
            this.unitOfWork = unitOfWork;
        }

        public Academic GetAcademic(string login)
        {
            return academicRepository.Get(x => x.Login == login);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Academic Auth(string login, string pass)
        {
            var user = academicRepository.Get(x => x.Login == login && x.Password == pass);
            return user;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="academic"></param>
        /// <returns></returns>
        public void Register(Academic academic)
        {
            academicRepository.Add(academic);
            unitOfWork.Commit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="academic"></param>
        /// <returns></returns>
        public void Unregister(Academic academic)
        {
            academicRepository.Delete(academic);
            unitOfWork.Commit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool RecoverPassword(string user)
        {
            //TODO: Terminar de implementar recuperação de senha

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public string GetSecretQuestion(string email)
        {
            var academic = academicRepository.Get(x => x.Email == email);

            if (academic != null)
                return academic.Email;
            else
                return null;
        }
    }
}
