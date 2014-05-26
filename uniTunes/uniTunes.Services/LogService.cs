using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Data.Infrastructure;
using uniTunes.Data.Repositories;
using uniTunes.Models;

namespace uniTunes.Services
{
    public interface ILogService
    {
        void Create(Log log);
    }

    public class LogService : ILogService
    {
        private readonly ILogRepository logRepository;
        private readonly IUnitOfWork unitOfWork;

        public LogService(ILogRepository logRepository, IUnitOfWork unitOfWork)
        {
            this.logRepository = logRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Persiste um objeto do tipo Log
        /// </summary>
        /// <param name="log"></param>
        public void Create(Log log)
        {
            logRepository.Add(log);
            unitOfWork.Commit();
        }
    }
}
