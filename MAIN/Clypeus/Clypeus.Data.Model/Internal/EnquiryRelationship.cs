using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Data.Model.Internal
{
    public class EnquiryRelationship
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string IsActive { get; set; }
    }
}
