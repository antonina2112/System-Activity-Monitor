using System;
using System.Collections.Generic;
using System.Text;
using trpz2.Models;

namespace trpz2.Visitor
{
    public class WindowComparer : IComparer<WindowInfo>
    {
        public int Compare(WindowInfo x, WindowInfo y)
        {
            if (x.ID > y.ID)
            {
                return 1;
            }
            else if (x.ID < y.ID)
            {
                return -1;
            }

            return 0;
        }
    }
}
