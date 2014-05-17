using System;
using uniTunes.Data;

namespace uniTunes.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        UniContext Get();
    }
}
