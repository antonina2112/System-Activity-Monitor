using System;
using System.Collections.Generic;
using System.Text;

namespace SAMWebService.Visitor
{
    public interface IVisitor
    {
        void VisitWindowsList(ListOfWindowsInfo windowsHolder);
    }
}
