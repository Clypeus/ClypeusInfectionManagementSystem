using Clypeus.Data.Model.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories.Interfaces
{
    public interface ILookupRepostiory
    {
        IEnumerable<EnquiryType> GetEnquiryTypes();
        IEnumerable<EnquiryRelationship> GetRelationshipTypes();

    }
}
