using System;
using System.Collections.Generic;
using System.Text;

namespace trpz2.Iterator
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}
