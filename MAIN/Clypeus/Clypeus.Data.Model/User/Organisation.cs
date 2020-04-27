using Clypeus.Data.Model.Geography;
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
        public string ContactName { get; set; }
        public int AddressId { get; set; }
        public string TelephoneNumber { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual Address Address { get; set; }
    }
}
