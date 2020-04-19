﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.Web.Components.Support
{
    public class PagedResult<T> : PagedResultBase where T : class
    {
        public IList<T> Results { get; set; }

        public PagedResult()
        {
            Results = new List<T>();
        }
    }
}
