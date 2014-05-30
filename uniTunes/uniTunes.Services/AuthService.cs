using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Data.Infrastructure;
using uniTunes.Data.Repositories;
using uniTunes.Models;

namespace uniTunes.Services
{
    public interface IAuthService
    {
        Academic Auth(string login, string pass);
        void Register(Academic academic);
        void Unregister(Academic academic);
        bool RecoverPassword(string user);
    }

    public class AuthService : IAuthService
    {
        private readonly IAcademicRepository academicRepository;
        private readonly IUnitOfWork unitOfWork;

        public AuthService(IAcademicRepository academicRepository, IUnitOfWork unitOfWork)
        {
            this.academicRepository = academicRepository;
            this.unitOfWork = unitOfWork;
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
            throw new NotImplementedException();
        }
    }
}
