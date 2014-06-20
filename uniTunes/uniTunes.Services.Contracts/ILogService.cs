using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models;

namespace uniTunes.Services.Contracts
{
    public interface ILogService
    {
        void Create(Log log);
    }
}
