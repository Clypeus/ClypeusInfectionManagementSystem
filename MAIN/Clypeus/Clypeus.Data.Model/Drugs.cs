using System;
using System.Collections.Generic;

namespace Clypeus.Data.Model
{
    public partial class Drugs
    {
        public Drugs()
        {
            DrugGroupMembers = new HashSet<DrugGroupMembers>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Atc { get; set; }
        public string Description { get; set; }
        public int? DrugTypeId { get; set; }
        public int? PrincipleDrugGroupId { get; set; }
        public bool? Active { get; set; }
        public DateTime? Inserted { get; set; }
        public DateTime? Updated { get; set; }

        public virtual DrugTypes DrugType { get; set; }
        public virtual DrugGroup PrincipleDrugGroup { get; set; }
        public virtual ICollection<DrugGroupMembers> DrugGroupMembers { get; set; }
    }
}
