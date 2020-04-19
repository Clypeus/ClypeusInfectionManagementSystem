using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

//This is based on the code provided by Gunner Piepman online at: https://gunnarpeipman.com/

namespace Clypeus.Web.Components
{
    public class PagerModel : ComponentBase
    {
        
        [Parameter]
        public int? NumberOfResults { get; set; }

        [Parameter]
        public int? ResultsPerPage { get; set;}

        [Parameter]
        public Action<int> PageChanged { get; set; }

        [Parameter]
        public int CurrentPage { get; set; } = 1;

        protected int StartIndex { get; private set; } = 0;
        protected int FinishIndex { get; private set; } = 0;

        protected int PageCount =0;

        protected override void OnParametersSet()
        {
            if (NumberOfResults.HasValue && ResultsPerPage.HasValue)
            {
                PageCount = (int)Math.Ceiling((double)NumberOfResults.Value / ResultsPerPage.Value);
            }

            StartIndex = Math.Max(CurrentPage - 3, 1);
            FinishIndex = Math.Min(CurrentPage + 3,PageCount);

            base.OnParametersSet();
        }

        protected void PagerButtonClicked(int page)
        {
            CurrentPage = page;
            StartIndex = Math.Max(CurrentPage - 3, 1);
            FinishIndex = Math.Min(CurrentPage + 3, PageCount);
            
            PageChanged?.Invoke(page);
        }
    }
}
