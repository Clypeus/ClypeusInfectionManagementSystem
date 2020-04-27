using Clypeus.Data.Model.Geography;
using Clypeus.Data.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Organisations
{
    public class PrimaryCarePractice
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }        
        public string TelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PrincipleContactName { get; set; }
        public string SeniorPracticeMemberId { get; set; }
        public int? AddressId { get; set; }
        public int? ParentOrganisationId { get; set; }
        public int? SecondaryOrganisationId { get; set; }
        public string Status { get; set; }
        public virtual Address Address { get; set; }
        public virtual Organisation ParentOrganisation { get; set; }
        public virtual Organisation SecondaryOrganisation { get; set; }

    }
}
