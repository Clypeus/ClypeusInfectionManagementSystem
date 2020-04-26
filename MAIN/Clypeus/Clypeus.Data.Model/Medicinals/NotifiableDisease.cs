using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Clypeus.Data.Model.Medicinals
{
    public class NotifiableDisease
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime? Inserted { get; set; }
        public DateTime? Updated { get; set; }
        public ICollection<NotifiableDiseaseOrganism> NotifiableDiseaseOrganisms { get; set; }
    }
}
