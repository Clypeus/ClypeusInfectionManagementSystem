using Clypeus.DataTransfer.ViewModels.Reference;
using Clypeus.Services.Interfaces.Medicinals;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clypeus.Pages.ReferenceData
{
    public class NotifiableDiseaseModel:ComponentBase
    {
        protected IEnumerable<NotifiableDiseasesViewModel> drugs;
        [Inject] protected INotifiableDiseaseService NotifiableDiseaseService { get; set; }

        protected string FilterString;

        private string sortColumn = "Description";
        private bool sortAscending = true;

        public int Count = 0;

        public int CurrentPage = 1;

        protected void SortList(string sortColumn)
        {
            this.sortColumn = sortColumn;
            sortAscending = !sortAscending;

            PerformAquistion(1);
        }

        protected override async Task OnInitializedAsync()
        {
            PerformAquistion();
        }

        protected void FilterHasBeenCleared()
        {
            FilterString = string.Empty;
            PerformAquistion();
        }

        protected void FilterHasBeenChanged(string updatedFilterString)
        {
            FilterString = updatedFilterString;
            PerformAquistion();
        }

        protected void PageChanged(int p)
        {
            PerformAquistion(p);
        }

        protected void PerformAquistion(int p = 1)
        {
            var results = NotifiableDiseaseService.GetNotifiableDisease(FilterString, p, 15, sortColumn, sortAscending).Result;
            drugs = results.Collection;
            Count = results.Count;
            CurrentPage = p;

            InvokeAsync(() =>
            {
                base.StateHasChanged();
            });
        }
    }
}
