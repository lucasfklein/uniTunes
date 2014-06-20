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
    public class AcademicService : IAcademicService
    {
        private readonly IAcademicRepository academicRepository;
        private readonly IUnitOfWork unitOfWork;

        public AcademicService(IAcademicRepository academicRepository, IUnitOfWork unitOfWork)
        {
            this.academicRepository = academicRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Retorna o Academic com o Id correspondente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Academic GetAcademic(int id)
        {
            return academicRepository.Get(x => x.AcademicId == id);
        }

        /// <summary>
        /// Valida o acesso do usuário
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Auth(string user, string password)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Academic> GetAcademics()
        {
            return academicRepository.GetAll();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEnumerable<Academic> GetUsersByLinkType(LinkType type)
        {
            return academicRepository.GetMany(x => x.Link == type);
        }
    }
}
