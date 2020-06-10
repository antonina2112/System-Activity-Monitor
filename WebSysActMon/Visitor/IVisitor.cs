using System;
using System.Collections.Generic;
using System.Text;

namespace WebSysActMon.Visitor
{
    public interface IVisitor
    {
        void VisitWindowsList(ListOfWindowsInfo windowsHolder);
    }
}
