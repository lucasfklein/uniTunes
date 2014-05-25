using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models;

namespace uniTunes.Services
{
    public interface ICreditService
    {
        Credit GetCredit(int id);
        IEnumerable<Credit> GetCredits();
        IEnumerable<CreditType> GetCreditTypes();
        bool SendOrder();
        bool ProcessOrder();
        // Liberar crédito
    }

    public class CreditService : ICreditService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Credit GetCredit(int id)
        {
            throw new NotImplementedException();
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
