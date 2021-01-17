using AutoMapper;
using Clypeus.Data.DatabaseWorkers.Repositories.Interfaces;
using Clypeus.Data.Model.Principles;
using Clypeus.DataTransfer.ViewModels.Enquiry;
using Clypeus.Services.Interfaces.Principles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Services.Principles
{
    public class EnquiryService : IEnquiryService
    {

        private readonly IEnquiryRepository enquiryRespository;
        private readonly IMapper mapper;

        public EnquiryService(IEnquiryRepository enquiryRespository, IMapper mapper)
        {
            this.enquiryRespository = enquiryRespository;
            this.mapper = mapper;
        }

        public bool SaveEnquiry(EnquiryForm model)
        {
            if (enquiryRespository.IsNew(model.Id))
            {
                var mapped = mapper.Map<Enquiry>(model);

                mapped.Created = DateTime.Now;
                mapped.Archived = "N";

                return enquiryRespository.SaveEnquiry(mapped);
            }
            else
            {
                var existingEnquiry = enquiryRespository.GetById(model.Id);
                var mapped = mapper.Map<EnquiryForm,Enquiry>(model,existingEnquiry);

                return enquiryRespository.SaveEnquiry(mapped);
            }
        }
    }
}
