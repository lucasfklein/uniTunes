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
    public class CreditService : ICreditService
    {
        private readonly ICreditRepository creditRepository;
        private readonly IAcademicRepository academicRepository;
        private readonly IUnitOfWork unitOfWork;

        public CreditService(ICreditRepository creditRepository, IAcademicRepository academicRepository, IUnitOfWork unitOfWork)
        {
            this.creditRepository = creditRepository;
            this.academicRepository = academicRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Academic AddCredit(Credit credit)
        {
            var academic = academicRepository.Get(x => x.AcademicId == credit.AcademicId);
            
            creditRepository.Add(credit);

            academic.Balance += credit.Value;
            academicRepository.Update(academic);

            unitOfWork.Commit();

            return academic;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Credit> GetCredits()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CreditType> GetCreditTypes()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool SendOrder()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool ProcessOrder()
        {
            throw new NotImplementedException();
        }   
    }

}
