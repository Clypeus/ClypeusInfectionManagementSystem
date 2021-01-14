using Clypeus.Data.Model.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Internal
{
    public class NoteText
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public int DeletedBy { get; set; }
        public DateTime? Deleted { get; set; }
        public virtual SystemUser  CreatedBySystemUser {get;set; }
        public virtual SystemUser DeletedBySystemUser { get; set; }

    }
}
