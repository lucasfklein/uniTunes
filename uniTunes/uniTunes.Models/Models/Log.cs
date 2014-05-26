using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Message { get; set; }
        public Academic User { get; set; }
    }
}
