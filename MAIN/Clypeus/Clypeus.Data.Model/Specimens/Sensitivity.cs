using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Specimens
{
    public class Sensitivity
    {
        public short Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ICollection<SpecimenSensitivity> SpecimenSensitivity {get;set;}
    }
}
