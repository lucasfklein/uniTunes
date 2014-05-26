using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models
{
    public partial class Media
    {
        [Key]
        public int MediaId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Academic Author { get; set; }
        public DateTime CreatedOn { get; set; }

        public bool IsFree
        {
            get
            {
                return (Price <= 0);
            }
        }
    }
}
