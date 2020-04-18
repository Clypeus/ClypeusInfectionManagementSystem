using Clypeus.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories.Implementions
{
    public class DrugRepository : Repository<Drugs>, IDrugRespository
    {
        private readonly ClypeusContext _clypeusContext;

        public DrugRepository(ClypeusContext context) : base(context)
        {
            _clypeusContext = context;
        }

        public IEnumerable<Drugs> GetAll(int drugType = 1, bool includeInactive = false)
        {
            var data = _clypeusContext.Drugs.Where(f => f.DrugTypeId == drugType);

            if (includeInactive)
                data = data.Where(f => f.Active == true);

            return data;
        }
    }
}
