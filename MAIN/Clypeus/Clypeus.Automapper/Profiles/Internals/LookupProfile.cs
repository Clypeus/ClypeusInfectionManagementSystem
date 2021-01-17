
using Clypeus.Core;
using Clypeus.Data.Model.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Automapper.Profiles.Internals
{
    public class LookupProfile : AutoMapper.Profile
    {
        public LookupProfile()
        {
            CreateMap<EnquiryRelationship, LookupElement>();
        }
    }
}
