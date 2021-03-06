﻿using Clypeus.DataTransfer.ViewModels.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.DataTransfer.ViewModels.Reference
{
    public class DrugsViewModel:GenericViewModel
    {
        public int Id { get; set; }

        public string AtcCode { get; set; }

        public string DrugGroup { get; set; }
    }
}
