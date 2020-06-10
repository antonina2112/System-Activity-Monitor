using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSysActMon.Models;

namespace WebSysActMon.Bridge
{
    public interface IPerformanceSingleton
    {
        List<Performance> GetPerformance();
    }
}
