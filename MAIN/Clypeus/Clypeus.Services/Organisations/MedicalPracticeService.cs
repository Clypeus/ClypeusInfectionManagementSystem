using AutoMapper;
using Clypeus.Data.DatabaseWorkers.Repositories;
using Clypeus.DataTransfer.ViewModels.Generic;
using Clypeus.DataTransfer.ViewModels.People;
using Clypeus.Services.Interfaces.Organisations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clypeus.Services.Organisations
{
    public class MedicalPracticeService : IMedicalPracticeService
    {
        private readonly IDrugRespository drugRespository;
        private readonly IMapper mapper;

        public Task<GenericReferenceModel<MedicalPractitonerViewModel>> GetPractices(MedicalPractitionerSearchVewModel searchVewModel)
        {
            throw new NotImplementedException();
        }
    }
}
