using uniTunes.Data.Infrastructure;
using uniTunes.Models;

namespace uniTunes.Data.Repositories
{
    public class AcademicRepository : RepositoryBase<Academic>, IAcademicRepository
    {
        public AcademicRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface IAcademicRepository : IRepository<Academic>
    {
    }
}