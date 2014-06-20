using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models;

namespace uniTunes.Services.Contracts
{
    public interface IAcademicService
    {
        Academic GetAcademic(int id);
        bool Auth(string user, string password);
        IEnumerable<Academic> GetAcademics();
        IEnumerable<Academic> GetUsersByLinkType(LinkType type);
    }
}

