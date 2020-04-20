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

        public Task<GenericReferenceModel<DrugsViewModel>> GetDrugs()
        {
            var drugData = GetDrugsData();
            var drugCount = Count();

            Task.WaitAll(drugData, drugCount);

            var model = new GenericReferenceModel<DrugsViewModel>()
            {
                Count = drugCount.Result,
                Collection = drugData.Result
            };

            return Task.FromResult(model);
        }
        private Task<IEnumerable<DrugsViewModel>> GetDrugsData()
        {
            var drugs = drugRespository.GetAll(1, false);

            var l = new List<DrugsViewModel>();

            foreach (var r in drugs)
                l.Add(new DrugsViewModel() { Code = r.Code, Description = r.Description, IsUsed = r.Active.GetValueOrDefault(), AtcCode = r.Atc });

            return Task.FromResult(l.AsEnumerable());
        }

        private Task<int> Count()
        {
            return Task.FromResult(drugRespository.Count(1, false, string.Empty));
        }
    }
}
