using System;
using System.Collections.Generic;

namespace Clypeus.Data.Model.Users
{
    public partial class Organisation
    {
        public Organisation()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string AddressLine5 { get; set; }
        public string TelephoneNumber { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
