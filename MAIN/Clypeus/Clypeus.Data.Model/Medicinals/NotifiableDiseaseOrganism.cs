using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clypeus.Data.Model.Medicinals
{
    public class NotifiableDiseaseOrganism
    {
        [Key]
        public int OrganismId { get; set; }

        [Key]
        public int NotifiableDiseaseId { get; set; }

        public virtual Organisms Organism {get;set;}

        public virtual NotifiableDisease NotifiableDisease { get; set; }
    }
}
