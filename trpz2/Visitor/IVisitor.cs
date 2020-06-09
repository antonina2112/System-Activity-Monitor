using System;
using System.Collections.Generic;
using System.Text;

namespace trpz2.Visitor
{
    public interface IVisitor
    {
        void VisitWindowsList(ListOfWindowsInfo windowsHolder);
    }
}
