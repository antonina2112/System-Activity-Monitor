using System;
using System.Collections.Generic;
using System.Text;

namespace SAMWebService.Visitor
{
    public class OrderedListVisitor : IVisitor
    {
        public void VisitWindowsList(ListOfWindowsInfo windowsHolder)
        {
            windowsHolder.GetWindows().Sort(new WindowComparer());
        }
    }
}
