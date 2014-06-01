using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace uniTunes.Models
{
    public partial class Account
    {
        [Key]
        public int AccountId { get; set; }
        public double Balance { get; set; }
        public virtual ICollection<Credit> Historic { get; set; }
    }
}
