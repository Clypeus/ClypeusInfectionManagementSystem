using Clypeus.Data.DatabaseWorkers.Repositories;
using Clypeus.DataTransfer.ViewModels.Generic;
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

        public Task<IEnumerable<GenericViewModel>> GetDrugs()
        {
            var drugs = drugRespository.GetAll(1, false);

            var l = new List<GenericViewModel>();

            foreach (var r in drugs)
                l.Add(new GenericViewModel() { Code = r.Code, Description = r.Description, IsUsed = r.Active.GetValueOrDefault()});

            return Task.FromResult(l.AsEnumerable());
        }
    }
}
