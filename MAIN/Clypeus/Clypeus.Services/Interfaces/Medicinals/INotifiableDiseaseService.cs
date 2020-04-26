using Clypeus.DataTransfer.ViewModels.Generic;
using Clypeus.DataTransfer.ViewModels.Reference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clypeus.Services.Interfaces.Medicinals
{
    public interface INotifiableDiseaseService
    {
        Task<GenericReferenceModel<NotifiableDiseasesViewModel>> GetNotifiableDisease(string filter = "", int page = 1, int recordPerPage = 15, string sortBy = "Description", bool sortAscending = true);
    }
}
