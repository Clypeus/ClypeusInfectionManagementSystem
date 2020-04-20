using Clypeus.DataTransfer.ViewModels.Generic;
using Clypeus.DataTransfer.ViewModels.Reference;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clypeus.Services.Interfaces.Medicinals
{
    public interface IDrugService
    {
        Task<GenericReferenceModel<DrugsViewModel>> GetDrugs(int drugType = 1, bool includeInactive = false, string filter = "", int page = 1, int recordPerPage = 15, string sortBy = "Description", bool sortAscending = true);
    }
}
