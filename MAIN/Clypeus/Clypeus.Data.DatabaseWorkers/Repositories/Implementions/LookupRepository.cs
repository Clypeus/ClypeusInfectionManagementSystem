using Clypeus.Data.DatabaseWorkers.Repositories.Interfaces;
using Clypeus.Data.Model;
using Clypeus.Data.Model.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories.Implementions
{
    public class LookupRepository : ILookupRepostiory
    {
        private readonly ClypeusContext _clypeusContext;

        public LookupRepository(ClypeusContext context)
        {
            _clypeusContext = context;
        }

        public IEnumerable<EnquiryType> GetEnquiryTypes()
        {
            return _clypeusContext.EnquiryTypes
                .Where(f => f.IsActive != "N");
        }

        public IEnumerable<EnquiryRelationship> GetRelationshipTypes()
        {
            return _clypeusContext.EnquiryRelationships
             .Where(f => f.IsActive != "N");
        }
    }
}
