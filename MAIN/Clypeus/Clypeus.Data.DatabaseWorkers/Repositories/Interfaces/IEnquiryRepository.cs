using Clypeus.Data.Model.Principles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories.Interfaces
{
    public interface IEnquiryRepository
    {
        bool IsNew(int id);

        public bool SaveEnquiry(Enquiry enquiry);

        public Enquiry GetById(int id);

        public Enquiry Populate(int id);
    }
}
