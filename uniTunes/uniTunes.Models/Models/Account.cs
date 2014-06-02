using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace uniTunes.Models
{
    public partial class Account
    {
        [DisplayName("Academic")]
        public int AcademicId { get; set; }

        [Key]
        public int AccountId { get; set; }

        public double Balance { get; set; }
        public virtual List<Credit> Historic { get; set; }

        public virtual Academic Academic { get; set; }
    }
}
