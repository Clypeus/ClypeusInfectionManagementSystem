using System;
using System.Collections.Generic;

namespace Clypeus.Data.Model
{
    public partial class Organisms
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? OrganismTypeId { get; set; }
        public bool? Active { get; set; }
        public DateTime? Inserted { get; set; }
        public DateTime? Updated { get; set; }

        public virtual OrganismTypes OrganismType { get; set; }
    }
}
