using System;
using System.Collections.Generic;
using System.Text;
using trpz2.Models;

namespace trpz2.Visitor
{
    public class ListOfWindowsInfo : IElement
    {
        List<WindowInfo> _windows = new List<WindowInfo>();

        public void Accept(IVisitor visitor)
        {
            WindowsStatistics.GetDesktopWindows(out List<WindowInfo> windows);

            _windows = windows;

            visitor.VisitWindowsList(this);
        }

        public List<WindowInfo> GetWindows()
        {
            return _windows;
        }
    }
}
