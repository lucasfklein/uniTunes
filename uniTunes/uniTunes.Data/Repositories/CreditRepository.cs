﻿using uniTunes.Data.Infrastructure;
using uniTunes.Models;

namespace uniTunes.Data.Repositories
{
    public class CreditRepository : RepositoryBase<Credit>, ICreditRepository
    {
        public CreditRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface ICreditRepository : IRepository<Credit>
    {
    }
}