using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Web.Components
{
    public class PageTitleModel : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }
    }
}
