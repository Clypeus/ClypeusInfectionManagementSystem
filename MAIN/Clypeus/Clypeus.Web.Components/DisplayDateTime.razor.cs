using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Web.Components
{
    public class DisplayDateTimeModel : ComponentBase
    {
        [Parameter]
        public string DisplayValue { get; set; }

        [Parameter]
        public DateTime RawValue { get; set; }

        [Parameter]
        public string Title { get; set; }

        protected override void OnInitialized()
        {
            RawValue = DateTime.Now;
            DisplayValue = string.Format("{0} {1}",Title,RawValue.ToString());
        }
    }
}
