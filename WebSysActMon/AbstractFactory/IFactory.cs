using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSysActMon.AbstractFactory
{
    public interface IFactory
    {
        IProduct CreateProduct();
    }
}
