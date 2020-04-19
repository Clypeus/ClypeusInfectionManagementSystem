using Clypeus.DataTransfer.ViewModels.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clypeus.Services.Interfaces.Medicinals
{
    public interface IDrugService
    {
        Task<IEnumerable<GenericViewModel>> GetDrugs();
    }
}
