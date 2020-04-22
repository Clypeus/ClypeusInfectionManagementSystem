using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Clypeus.Web.Components
{
    public class FilterBoxModel:ComponentBase
    {
        [Parameter]
        public int Debounce { get; set; } = 1000;

        [Parameter]
        public string FilterString { get; set; }

        [Parameter]
        public Action<string> FilterTextChanged { get; set; }

        [Parameter]
        public Action FilterCleared { get; set; }
    }
}
