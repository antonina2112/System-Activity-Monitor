using System;
using System.Collections.Generic;
using System.Text;

namespace trpz2.Visitor
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
