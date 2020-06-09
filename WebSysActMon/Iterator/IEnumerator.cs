using System;
using System.Collections.Generic;
using System.Text;

namespace trpz2.Iterator
{
    public interface IEnumerator
    {
        bool MoveNext();
        void Reset();
        object Current { get; }
    }
}
