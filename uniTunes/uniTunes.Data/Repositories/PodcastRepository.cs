using uniTunes.Data.Infrastructure;
using uniTunes.Models;

namespace uniTunes.Data.Repositories
{
    public class PodcastRepository : RepositoryBase<Podcast>, IPodcastRepository
    {
        public PodcastRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface IPodcastRepository : IRepository<Podcast>
    {
    }
}