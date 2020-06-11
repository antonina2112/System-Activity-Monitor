using System;
using System.Collections.Generic;
using System.Text;
using SAMWebService.Models;

namespace SAMWebService.AbstractFactory
{
    public class KeyboardHookFactory:IFactory
    {
        public IProduct CreateProduct()
        {
            return new KeyboardHook();
        }
    }
}
