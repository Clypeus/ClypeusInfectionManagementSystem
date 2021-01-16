using Clypeus.DataTransfer.ViewModels.Enquiry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Services.Interfaces.Principles
{
    public interface IEnquiryService
    {
        bool SaveEnquiry(EnquiryForm model);
    }
}
