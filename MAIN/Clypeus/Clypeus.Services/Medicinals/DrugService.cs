using Clypeus.Data.DatabaseWorkers.Repositories;
using Clypeus.DataTransfer.ViewModels.Generic;
using Clypeus.DataTransfer.ViewModels.Reference;
using Clypeus.Services.Interfaces.Medicinals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clypeus.Services.Medicinals
{
    public class DrugService : IDrugService
    {
        public IDrugRespository drugRespository;

        public DrugService(IDrugRespository drugRespository)
        {
            this.drugRespository = drugRespository;
        }

        public Task<GenericReferenceModel<DrugsViewModel>> GetDrugs(int drugType = 1, bool includeInactive = false, string filter = "", int page = 1, int recordPerPage = 15, string sortBy = "Description", bool sortAscending = true)
        {
            var drugData = GetDrugsData(drugType,includeInactive,filter,page,recordPerPage,sortBy,sortAscending);
            var drugCount = Count(drugType,includeInactive,filter);

            Task.WaitAll(drugData, drugCount);

            var model = new GenericReferenceModel<DrugsViewModel>()
            {
                Count = drugCount.Result,
                Collection = drugData.Result
            };

            return Task.FromResult(model);
        }
        private Task<IEnumerable<DrugsViewModel>> GetDrugsData(int drugType, bool includeInactive, string filter, int page, int recordPerPage, string sortBy, bool sortAscending)
        {
            var drugs = drugRespository.GetAll(1, false,filter,page,recordPerPage,sortBy,sortAscending);

            var l = new List<DrugsViewModel>();

            foreach (var r in drugs)
                l.Add(new DrugsViewModel() { Code = r.Code, Description = r.Description, IsUsed = r.Active.GetValueOrDefault(), AtcCode = r.Atc });

            return Task.FromResult(l.AsEnumerable());
        }

        private Task<int> Count(int drugType, bool includeInactive, string filter)
        {
            return Task.FromResult(drugRespository.Count(drugType,includeInactive,filter));
        }
    }
}
