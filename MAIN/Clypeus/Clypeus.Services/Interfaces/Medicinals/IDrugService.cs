using Clypeus.DataTransfer.ViewModels.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Services.Interfaces.Medicinals
{
    public interface IDrugService
    {
        IEnumerable<GenericViewModel> GetDrugs();
    }
}
