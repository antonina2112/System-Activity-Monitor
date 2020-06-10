using System;
using System.Collections.Generic;
using System.Text;
using WebSysActMon.Models;

namespace WebSysActMon.AbstractFactory
{
    public class KeyboardHookFactory:IFactory
    {
        public IProduct CreateProduct()
        {
            return new KeyboardHook();
        }
    }
}
