using Clypeus.DataTransfer.ViewModels.Generic;
using Clypeus.DataTransfer.ViewModels.Reference;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clypeus.Services.Interfaces.Medicinals
{
    public interface IDrugService
    {
        Task<GenericReferenceModel<DrugsViewModel>> GetDrugs();
    }
}
