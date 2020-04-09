using System;
using System.Collections.Generic;

namespace Clypeus.Data.Model
{
    public partial class DrugTypes
    {
        public DrugTypes()
        {
            DrugGroup = new HashSet<DrugGroup>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public DateTime? Inserted { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<DrugGroup> DrugGroup { get; set; }
    }
}
