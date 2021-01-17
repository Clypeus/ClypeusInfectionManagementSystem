using Clypeus.Data.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Principles
{
    public class Enquiry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string HouseName { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Area { get; set; }
        public string Postcode { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string RelationshipTypeId { get; set; }
        public string EnquiryTypeId { get; set; }
        public string Location { get; set; }
        public string SubjectTitle { get; set; }
        public string SubjectDescription { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public string Archived { get; set; }
        public virtual SystemUser CreatedBySystemUser { get; set; }



    }
}
