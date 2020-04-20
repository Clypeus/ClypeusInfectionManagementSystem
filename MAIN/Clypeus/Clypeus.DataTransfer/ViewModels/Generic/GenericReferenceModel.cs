using System;
using System.Collections.Generic;
using System.Text;

namespace Clypeus.DataTransfer.ViewModels.Generic
{
    public class GenericReferenceModel<T> where T:class
    {
        public IEnumerable<T> Collection { get; set; }

        public int Count { get; set; }
    }
}
