using System;
using System.Collections.Generic;
using System.Text;

namespace WebSysActMon.Iterator
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }
}
