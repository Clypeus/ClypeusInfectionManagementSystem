using AutoMapper;
using Clypeus.Data.DatabaseWorkers.Repositories;
using Clypeus.Data.DatabaseWorkers.Repositories.Interfaces;
using Clypeus.Data.Model.Medicinals;
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
    public class NotifiableDiseaseService:INotifiableDiseaseService
    {
        private readonly INotifiableDiseaseRespository notifiableDiseaseRespository;
        private readonly IMapper mapper;

        public NotifiableDiseaseService(INotifiableDiseaseRespository drugRespository, IMapper mapper)
        {
            this.notifiableDiseaseRespository = drugRespository;
            this.mapper = mapper;
        }

        public Task<GenericReferenceModel<NotifiableDiseasesViewModel>> GetNotifiableDisease(string filter = "", int page = 1, int recordPerPage = 15, string sortBy = "Description", bool sortAscending = true)
        {
            var drugData = GetNotifiableData(filter, page, recordPerPage, sortBy, sortAscending);
            var drugCount = Count(filter);

            Task.WaitAll(drugData, drugCount);

            var model = new GenericReferenceModel<NotifiableDiseasesViewModel>()
            {
                Count = drugCount.Result,
                Collection = drugData.Result
            };

            return Task.FromResult(model);
        }
        private Task<IEnumerable<NotifiableDiseasesViewModel>> GetNotifiableData(string filter, int page, int recordPerPage, string sortBy, bool sortAscending)
        {
            var nd = notifiableDiseaseRespository.GetAll(filter, page, recordPerPage, sortBy, sortAscending);
            var l = mapper.Map<IEnumerable<NotifiableDisease>, IEnumerable<NotifiableDiseasesViewModel>>(nd);

            return Task.FromResult(l.AsEnumerable());
        }

        private Task<int> Count(string filter)
        {
            return Task.FromResult(notifiableDiseaseRespository.Count(filter));
        }
    }
}
