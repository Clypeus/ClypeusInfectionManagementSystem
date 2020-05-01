using Clypeus.Data.Model.Medicinals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Specimens
{
    public class SpecimenSensitivity
    {
        public long SpecimenId { get; set; }
        public int OrganismId { get; set; }
        public int DrugId { get; set; }
        public short SensitivityId { get; set; }
        public virtual Sensitivity Sensitivity { get; set; }
        public virtual Drugs Drug {get;set;}
        public virtual Specimen Specimen { get; set; }
        public virtual Organisms Organism { get; set; }
    }
}
