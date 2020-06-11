using System;
using System.Collections.Generic;
using System.Text;
using SAMWebService.Models;

namespace SAMWebService.Visitor
{
    public class ObjectStructure
    {
        readonly List<IElement> _elements = new List<IElement>();

        public void Add(IElement acc)
        {
            if (!_elements.Contains(acc))
                _elements.Add(acc);
        }

        public void Remove(IElement acc)
        {
            _elements.Remove(acc);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IElement element in _elements)
                element.Accept(visitor);
        }

        public List<WindowInfo> GetWindows()
        {
            foreach (var element in _elements)
            {
                if (element is ListOfWindowsInfo)
                {
                    return (element as ListOfWindowsInfo).GetWindows();
                }
            }

            return new List<WindowInfo>();
        }
         
        
    }
}
