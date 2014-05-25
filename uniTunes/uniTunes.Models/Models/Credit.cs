using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models
{
    public partial class Credit
    {
        public int CreditId { get; set; }
        public double Value { get; set; }
        public CreditStatus Status { get; set; }
        public CreditType Type { get; set; }
    }

    public enum CreditStatus
    {
        Waiting = 1,
        Processing = 2,
        Canceled = 3,
        Completed = 4
    }

    public enum CreditType
    {
        Billet = 1, // Boleto
        Transfer = 2, // Transferencia Bancária
        CreditCard = 3 // Cartão de Crédito
    }
}
