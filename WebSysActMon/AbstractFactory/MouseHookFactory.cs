using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpz2.Models;

namespace trpz2.AbstractFactory
{
    public class MouseHookFactory:IFactory
    {
        public IProduct CreateProduct()
        {
            return new MouseHook();
        }
    }
}
