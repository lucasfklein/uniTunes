using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace uniTunes.Models.Models
{
    public class Balance
    {
        [Key]
        public int BalanceId;
        public double Value;
        public ICollection<Credit> Historic;
    }
}
