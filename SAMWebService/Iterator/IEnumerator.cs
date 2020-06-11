using System;
using System.Collections.Generic;
using System.Text;

namespace SAMWebService.Iterator
{
    public interface IEnumerator
    {
        bool MoveNext();
        void Reset();
        object Current { get; }
    }
}
