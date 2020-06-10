using System;
using System.Collections.Generic;
using System.Text;

namespace WebSysActMon.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
