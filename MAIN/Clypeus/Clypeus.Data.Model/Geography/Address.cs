using Clypeus.Data.Model.Organisations;
using Clypeus.Data.Model.Specimens;
using Clypeus.Data.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Geography
{
    public class Address
    {
        public Address()
        {
            SystemOrganisations = new HashSet<SystemOrganisations>();
            PrimaryCarePractices = new HashSet<PrimaryCarePractice>();
        }

        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string Postcode { get; set; }
        public DateTime? Inserted { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<SystemOrganisations> SystemOrganisations { get; set; }

        public virtual ICollection<PrimaryCarePractice> PrimaryCarePractices { get; set; }

        public virtual Lab Lab { get; set; }
    }
}
