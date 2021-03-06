﻿using Clypeus.Data.Model.Internal;
using Clypeus.Data.Model.Principles;
using System;
using System.Collections.Generic;

namespace Clypeus.Data.Model.Users
{
    public partial class SystemUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateRegistered { get; set; }
        public DateTime? LastAccessed { get; set; }
        public int OrganisationId { get; set; }
        public string ContactAddressLine1 { get; set; }
        public string ContactAddressLine2 { get; set; }
        public string ContactAddressLine3 { get; set; }
        public string ContactAddressLine4 { get; set; }
        public string ContactAddressLine5 { get; set; }
        public string TelephoneNumber { get; set; }
        public string MobileTelephoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool Active { get; set; }

        public virtual SystemOrganisations SystemOrganisation { get; set; }

        public virtual ICollection<NoteText> NotesCreated { get; set; }

        public virtual ICollection<NoteText> NotesDeleted { get; set; }

        public virtual ICollection<Enquiry> EnquiriesCreated { get; set; }
    }
}
