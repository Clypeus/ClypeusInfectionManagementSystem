using AutoMapper;
using Clypeus.Data.DatabaseWorkers.Repositories.Interfaces;
using Clypeus.Services.Interfaces.Internals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Clypeus.Core;

namespace Clypeus.Services.Internals
{

    public class LookupService:ILookupService
    {
        private readonly ILookupRepostiory lookupRespository;
        private readonly IMapper mapper;

        public LookupService(ILookupRepostiory lookupRepostiory,IMapper mapper)
        {
            this.lookupRespository = lookupRepostiory;
            this.mapper = mapper;
        }

        public IEnumerable<LookupElement> GetLookupElements(LookupTypes lookupTypes, bool onlyActive = false)
        {
            switch (lookupTypes)
            {
                case LookupTypes.EnquiryRelationshipType:
                    return getRelationshipTypes(onlyActive);  
            }

            return new List<LookupElement>().AsEnumerable();
        }

        private IEnumerable<LookupElement> getRelationshipTypes(bool onlyActive)
        {
            var data = lookupRespository.GetRelationshipTypes();

            if (onlyActive)
            {
                return data.Where(f=>f.IsActive != "N")
                    .Select(f => new LookupElement { Key = Convert.ToString(f.Code), Value = f.ShortDescription });

            } else
            {
                return data.Select(f => new LookupElement { Key = Convert.ToString(f.Code), Value = f.ShortDescription });
            }           
        }

        private IEnumerable<LookupElement> getEnquiryTypes(bool onlyActive)
        {
            var data = lookupRespository.GetEnquiryTypes();

            if (onlyActive)
            {
                return data.Where(f => f.IsActive != "N")
                    .Select(f => new LookupElement { Key = Convert.ToString(f.Code), Value = f.ShortDescription });

            }
            else
            {
                return data.Select(f => new LookupElement { Key = Convert.ToString(f.Code), Value = f.ShortDescription });
            }
        }
    }

    public enum LookupTypes
    {
        EnquiryRelationshipType,
        EnquiryType
    }
}
