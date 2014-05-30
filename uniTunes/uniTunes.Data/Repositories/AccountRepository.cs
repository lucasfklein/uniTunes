using uniTunes.Data.Infrastructure;
using uniTunes.Models;

namespace uniTunes.Data.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface IAccountRepository : IRepository<Account>
    {
    }
}