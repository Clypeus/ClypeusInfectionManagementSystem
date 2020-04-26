using System;
using System.Collections.Generic;

namespace Clypeus.Data.Model.Medicinals
{
    public partial class OrganismGenus
    {
        public OrganismGenus()
        {
            Organisms = new HashSet<Organisms>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public DateTime? Inserted { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<Organisms> Organisms { get; set; }
    }
}
