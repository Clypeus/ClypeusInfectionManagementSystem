using System;
using System.Collections.Generic;

namespace Clypeus.Data.Model
{
    public partial class Organisms
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Species { get; set; }
        public int? OrganismTypeId { get; set; }
        public int? OrganismKingdomId { get; set; }
        public int? OrganismPhylumId { get; set; }
        public int? OrganismFamilyId { get; set; }
        public int? OrganismClassId { get; set; }
        public int? OrganismOrderId { get; set; }
        public bool? Active { get; set; }
        public DateTime? Inserted { get; set; }
        public DateTime? Updated { get; set; }

        public virtual OrganismTypes OrganismType { get; set; }

        public virtual OrganismKingdom OrganismKingdom { get; set; }

        public virtual OrganismPhylum OrganismPhylum { get; set; }

        public virtual OrganismFamily OrganismFamily { get; set; }

        public virtual OrganismClass OrganismClass { get; set; }

        public virtual OrganismOrder OrganismOrder { get; set; }
    }
}
