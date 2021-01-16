using Clypeus.DataTransfer.ViewModels.Enquiry;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clypeus.Pages.Enquiry
{
    public class CreateEnquiryModel:ComponentBase
    {
        public DataTransfer.ViewModels.Enquiry.EnquiryForm enquiryModel = new DataTransfer.ViewModels.Enquiry.EnquiryForm();
        public string selectedTab = "home";

        public void OnSelectedTabChanged(string name)
        {
            selectedTab = name;
        }
        public void HandleValidSubmit()
        {

        }
    }
}
