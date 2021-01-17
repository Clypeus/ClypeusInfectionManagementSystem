using AutoMapper;
using Clypeus.Core;
using Clypeus.Services.Internals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Services.Interfaces.Internals
{
    public interface ILookupService
    {
        public IEnumerable<LookupElement> GetLookupElements(LookupTypes lookupTypes, bool onlyActive = false);
    }
}
