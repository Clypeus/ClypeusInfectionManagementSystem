using Clypeus.Data.Model.Geography;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Specimens
{
    public class Lab
    {
        public int Id { get; set; }
        public string Code { get; set; } 
        public string Description { get; set; } 
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactTelephone { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
