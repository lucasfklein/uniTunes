using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Data.Infrastructure;
using uniTunes.Models.Models;

namespace uniTunes.Data.Repositories
{
    public class LogRepository : RepositoryBase<Log>, ILogRepository
    {
        public LogRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface ILogRepository : IRepository<Log>
    {
    }
}
