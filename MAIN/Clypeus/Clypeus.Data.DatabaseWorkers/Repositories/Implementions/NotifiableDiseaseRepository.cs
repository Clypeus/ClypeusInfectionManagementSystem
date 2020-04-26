using Clypeus.Data.DatabaseWorkers.Repositories.Interfaces;
using Clypeus.Data.Model;
using Clypeus.Data.Model.Medicinals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories.Implementions
{
    public class NotifiableDiseaseRepository : Repository<NotifiableDisease>, INotifiableDiseaseRespository
    {
        private readonly ClypeusContext _clypeusContext;

        public NotifiableDiseaseRepository(ClypeusContext context) : base(context)
        {
            _clypeusContext = context;
        }

        public IEnumerable<NotifiableDisease> GetAll(string filter = "", int page = 1, int recordPerPage = 15, string sortBy = "Description", bool sortAscending = true)
        {
            var data = _clypeusContext.NotifiableDiseases.AsQueryable();

            data = ApplyFilter(data, filter);
            data = Sort(data, sortBy, sortAscending);
            data = ApplyPage(data, page, recordPerPage);

            return data;
        }

        public int Count(string filter = "")
        {
            var data = _clypeusContext.NotifiableDiseases.AsQueryable();
            data = ApplyFilter(data, filter);

            return data.Count();
        }

        private IQueryable<NotifiableDisease> ApplyPage(IQueryable<NotifiableDisease> data, int page, int recordPerPage)
        {
            return data.Skip((page - 1) * recordPerPage).Take(recordPerPage);
        }

        private IQueryable<NotifiableDisease> Sort(IQueryable<NotifiableDisease> data, string sortBy, bool sortAscending)
        {
            switch (sortBy)
            {
                case "Code":
                    return sortAscending ? data.OrderBy(f => f.Code) : data.OrderByDescending(f => f.Code);
                 case "Description":
                    return sortAscending ? data.OrderBy(f => f.Description) : data.OrderByDescending(f => f.Description);
                default:
                    return sortAscending ? data.OrderBy(f => f.Code) : data.OrderByDescending(f => f.Code);
            }
        }

        private IQueryable<NotifiableDisease> ApplyFilter(IQueryable<NotifiableDisease> data, string filter)
        {
            if (string.IsNullOrEmpty(filter))
                return data;
            else
                return data.Where(f => f.Code.Contains(filter)
                || f.Description.Contains(filter));
        }
    }
}
