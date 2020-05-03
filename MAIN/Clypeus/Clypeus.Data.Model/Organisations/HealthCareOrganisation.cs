using Clypeus.Data.Model.Geography;
using Clypeus.Data.Model.Specimens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Organisations
{
    public class HealthCareOrganisation
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactTelephone { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int? ParentId { get; set; }
        public virtual HealthCareOrganisation Parent { get; set; }
        public virtual ICollection<HealthCareOrganisation> Children { get; set; }
        public virtual ICollection<Lab> Labs { get; set; }
    


}
}
