using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers
{
    public interface IUnitOfWork : IDisposable
    {

        int Complete();
    }
}
