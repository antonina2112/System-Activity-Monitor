using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpz2.Models;

namespace trpz2.Bridge
{
    public interface IPerformanceSingleton
    {
        List<Performance> GetPerformance();
    }
}
