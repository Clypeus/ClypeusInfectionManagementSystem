using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Timers;

namespace Clypeus.Web.Components
{
    public class FilterBoxModel:ComponentBase
    {
        private System.Timers.Timer debounceTimer;

        [Parameter]
        public int Debounce { get; set; } = 1000;

        [Parameter]
        public string FilterString { get; set; }

        [Parameter]
        public Action<string> FilterTextChanged { get; set; }

        [Parameter]
        public Action FilterCleared { get; set; }

        protected override void OnInitialized()
        {
            debounceTimer = new System.Timers.Timer(Debounce);
            debounceTimer.Elapsed += OnTextInputFinished;
            debounceTimer.AutoReset = false;
        }

        protected void HandleKeyUp(KeyboardEventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void OnTextInputFinished(Object source, ElapsedEventArgs e)
        {

            InvokeAsync(() =>
            {
                StateHasChanged();
                FilterTextChanged(FilterString);
            });
        }
    }
}
