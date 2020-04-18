using Clypeus.Data.DatabaseWorkers.Repositories;
using Clypeus.Data.DatabaseWorkers.Repositories.Implementions;
using Clypeus.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.DatabaseWorkers
{
    class UnitOfWork
    {
        private readonly ClypeusContext _context;

        public UnitOfWork(ClypeusContext context)
        {
            _context = context;
            Drugs = new DrugRepository(_context);
        }

        public IDrugRespository Drugs { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
