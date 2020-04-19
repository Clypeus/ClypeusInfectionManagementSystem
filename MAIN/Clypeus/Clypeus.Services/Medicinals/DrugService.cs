using Clypeus.Data.DatabaseWorkers.Repositories;
using Clypeus.DataTransfer.ViewModels.Generic;
using Clypeus.Services.Interfaces.Medicinals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clypeus.Services.Medicinals
{
    public class DrugService : IDrugService
    {
        public IDrugRespository drugRespository;

        public DrugService(IDrugRespository drugRespository)
        {
            this.drugRespository = drugRespository; 
        }

        public IEnumerable<GenericViewModel> GetDrugs()
        {
            return new List<GenericViewModel>().AsEnumerable();
        }
    }
}
