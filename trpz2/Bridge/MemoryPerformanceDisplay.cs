using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpz2.Bridge
{
    public class MemoryPerformanceDisplay : AbstractPerformanceDisplay
    {
        public MemoryPerformanceDisplay(IPerformanceSingleton performanceSingleton) : base(performanceSingleton)
        {
        }
    }
}
