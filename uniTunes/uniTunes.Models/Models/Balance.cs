using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace uniTunes.Models
{
    public class Balance
    {
        [Key]
        public int BalanceId { get; set; }
        public double Value { get; set; }
        public ICollection<Credit> Historic { get; set; }
    }
}
