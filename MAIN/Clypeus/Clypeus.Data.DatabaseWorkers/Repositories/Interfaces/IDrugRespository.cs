using Clypeus.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories
{
    public interface IDrugRespository:IRepository<Drugs>
    {
        IEnumerable<Drugs> GetAll(int drugType = 1,bool includeInactive = false);
    }
}
