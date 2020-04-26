using Clypeus.Data.Model;
using Clypeus.Data.Model.Medicinals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories
{
    public interface IDrugRespository:IRepository<Drugs>
    {
        IEnumerable<Drugs> GetAll(int drugType = 1,bool includeInactive = false, string filter = "", int page=1,int recordPerPage= 15, string sortBy="Description",bool sortAscending=true);

        int Count(int drugType = 1, bool includeInactive = false, string filter = "");
    

    }
}
