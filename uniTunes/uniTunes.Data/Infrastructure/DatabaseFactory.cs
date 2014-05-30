using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniTunes.Data.Infrastructure
{
public class DatabaseFactory : Disposable, IDatabaseFactory
{
    private UniContext dataContext;
    public UniContext Get()
    {
        return dataContext ?? (dataContext = new UniContext());
    }
    protected override void DisposeCore()
    {
        if (dataContext != null)
            dataContext.Dispose();
    }
}
}
