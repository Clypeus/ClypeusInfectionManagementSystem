using Clypeus.Data.Model;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Drugs> GetAll(int drugType = 1, bool includeInactive = false, string filter = "", int page = 1, int recordPerPage = 15, string sortBy = "Description", bool sortAscending = true)
        {
            var data = _clypeusContext.Drugs
                .Include(f => f.PrincipleDrugGroup)
                .Where(f => f.DrugTypeId == drugType);

            if (includeInactive)
                data = data.Where(f => f.Active == true);

            data = ApplyFilter(data, filter);
            data = Sort(data, sortBy, sortAscending);
            data = ApplyPage(data, page, recordPerPage);

            return data;
        }

        public int Count(int drugType = 1, bool includeInactive = false, string filter = "")
        {
            var data = _clypeusContext.Drugs.Where(f => f.DrugTypeId == drugType);

            if (includeInactive)
                data = data.Where(f => f.Active == true);

            data = ApplyFilter(data, filter);

            return data.Count();
        }

        private IQueryable<Drugs> ApplyPage(IQueryable<Drugs> data, int page, int recordPerPage)
        {
            return data.Skip((page - 1) * recordPerPage).Take(recordPerPage);
        }

        private IQueryable<Drugs> Sort(IQueryable<Drugs> data, string sortBy, bool sortAscending)
        {
            switch (sortBy)
            {
                case "Code":
                    return sortAscending ? data.OrderBy(f => f.Code) : data.OrderByDescending(f => f.Code);
                case "Atc":
                    return sortAscending ? data.OrderBy(f => f.Atc) : data.OrderByDescending(f => f.Atc);
                case "Description":
                    return sortAscending ? data.OrderBy(f => f.Description) : data.OrderByDescending(f => f.Description);
                case "Group":
                    return sortAscending ? data.OrderBy(f => f.PrincipleDrugGroup.Description) : data.OrderByDescending(f => f.PrincipleDrugGroup.Description);
                default:
                    return sortAscending ? data.OrderBy(f => f.Code) : data.OrderByDescending(f => f.Code);
            }
        }

        private IQueryable<Drugs> ApplyFilter(IQueryable<Drugs> data, string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return data;
            else
                return data.Where(f => f.Code.Contains(filter)
                || f.Description.Contains(filter)
                || f.Atc.Contains(filter)
                || f.PrincipleDrugGroup.Description.Contains(filter));
        }
    }
}
