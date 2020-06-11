using System;
using System.Collections.Generic;
using System.Text;

namespace SAMWebService.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
