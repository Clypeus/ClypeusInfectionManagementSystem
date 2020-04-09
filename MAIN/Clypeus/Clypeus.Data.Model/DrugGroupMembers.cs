using System;
using System.Collections.Generic;

namespace Clypeus.Data.Model
{
    public partial class DrugGroupMembers
    {
        public int DrugGroupId { get; set; }
        public int DrugId { get; set; }

        public virtual Drugs Drug { get; set; }
        public virtual DrugGroup DrugGroup { get; set; }
    }
}
