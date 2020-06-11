using System;
using System.Collections.Generic;
using System.Text;

namespace SAMWebService.Iterator
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}
