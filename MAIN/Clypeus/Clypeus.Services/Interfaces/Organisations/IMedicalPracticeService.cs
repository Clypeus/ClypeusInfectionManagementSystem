using Clypeus.DataTransfer.ViewModels.Generic;
using Clypeus.DataTransfer.ViewModels.People;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clypeus.Services.Interfaces.Organisations
{
    public interface IMedicalPracticeService
    {
        Task<GenericReferenceModel<MedicalPractitonerViewModel>> GetPractices(MedicalPractitionerSearchVewModel searchVewModel);
    }
}
