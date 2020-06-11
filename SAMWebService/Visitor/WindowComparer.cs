using System;
using System.Collections.Generic;
using System.Text;
using SAMWebService.Models;

namespace SAMWebService.Visitor
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
