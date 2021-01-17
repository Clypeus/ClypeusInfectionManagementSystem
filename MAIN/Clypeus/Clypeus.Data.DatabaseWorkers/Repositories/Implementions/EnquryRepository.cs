using Clypeus.Data.DatabaseWorkers.Repositories.Interfaces;
using Clypeus.Data.Model;
using Clypeus.Data.Model.Principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories.Implementions
{
    public class EnquiryRepository: Repository<Enquiry>, IEnquiryRepository
    {
        private readonly ClypeusContext _clypeusContext;

        public EnquiryRepository(ClypeusContext context) : base(context)
        {
            _clypeusContext = context;
        }

        public bool IsNew(int id)
        {
            return !_clypeusContext.Enquiries.Any(f => f.Id == id);
        }

        public bool SaveEnquiry(Enquiry enquiry)
        {
            if (enquiry == null)
                return false;

            _clypeusContext.Enquiries.Add(enquiry);

            try
            {
                var saved = _clypeusContext.SaveChanges();

                if (saved == 1)
                    return true;
                else
                    return false;

            } catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
