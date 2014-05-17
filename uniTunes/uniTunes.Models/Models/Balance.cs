using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models.Models
{
    public class Balance
    {
        public double Value;
        public IEnumerable<Credit> Historic;
    }
}
