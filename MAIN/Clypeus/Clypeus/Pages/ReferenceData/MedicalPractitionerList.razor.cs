using Clypeus.DataTransfer.ViewModels.Organisations;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clypeus.Pages.ReferenceData
{
    public class MedicalPractitionerListModel:ComponentBase
    {
        public MedicalPractitionerSearchVewModel searchModel = new MedicalPractitionerSearchVewModel();

        public void HandleValidSubmit()
        {
            
        }

        public void Search()
        {

        }

        public void ClearForm()
        {
            searchModel.Code = null;
            searchModel.Name = null;
        }

    }
}
