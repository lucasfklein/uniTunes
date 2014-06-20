using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models;

namespace uniTunes.Services.Contracts
{
    public interface ICreditService
    {
        Academic AddCredit(Credit credit);
        IEnumerable<Credit> GetCredits();
        IEnumerable<CreditType> GetCreditTypes();
        bool SendOrder();
        bool ProcessOrder();
    }
}
