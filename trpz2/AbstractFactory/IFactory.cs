using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpz2.AbstractFactory
{
    public interface IFactory
    {
        IProduct CreateProduct();
    }
}
