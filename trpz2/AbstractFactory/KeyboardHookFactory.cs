using System;
using System.Collections.Generic;
using System.Text;
using trpz2.Models;

namespace trpz2.AbstractFactory
{
    public class KeyboardHookFactory:IFactory
    {
        public IProduct CreateProduct()
        {
            return new KeyboardHook();
        }
    }
}
