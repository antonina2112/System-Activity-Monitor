﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMWebService.AbstractFactory
{
    public interface IFactory
    {
        IProduct CreateProduct();
    }
}
