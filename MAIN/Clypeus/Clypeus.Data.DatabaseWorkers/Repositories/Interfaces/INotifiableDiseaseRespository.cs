using Clypeus.Data.Model.Medicinals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers.Repositories.Interfaces
{
    public interface INotifiableDiseaseRespository
    {
        IEnumerable<NotifiableDisease> GetAll(string filter = "", int page = 1, int recordPerPage = 15, string sortBy = "Description", bool sortAscending = true);

        int Count(string filter = "");
    }
}
