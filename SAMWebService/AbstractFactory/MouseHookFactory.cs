using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMWebService.Models;

namespace SAMWebService.AbstractFactory
{
    public class MouseHookFactory:IFactory
    {
        public IProduct CreateProduct()
        {
            return new MouseHook();
        }
    }
}
