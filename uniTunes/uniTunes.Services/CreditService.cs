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
    public interface ICreditService
    {
        void AddCredit(Credit credit);
        IEnumerable<Credit> GetCredits();
        IEnumerable<CreditType> GetCreditTypes();
        bool SendOrder();
        bool ProcessOrder();
        // Liberar crédito
    }

    public class CreditService : ICreditService
    {
        private readonly ICreditRepository creditRepository;
        private readonly IUnitOfWork unitOfWork;

        public CreditService(ICreditRepository creditRepository, IUnitOfWork unitOfWork)
        {
            this.creditRepository = creditRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void AddCredit(Credit credit)
        {
            creditRepository.Add(credit);
            unitOfWork.Commit();
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
