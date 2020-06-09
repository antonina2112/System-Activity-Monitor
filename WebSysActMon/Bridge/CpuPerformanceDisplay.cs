using System;
using System.Collections.Generic;
using System.Text;

namespace trpz2.Bridge
{
    public class CpuPerformanceDisplay: AbstractPerformanceDisplay
    {
        public CpuPerformanceDisplay(IPerformanceSingleton performanceSingleton) : base(performanceSingleton)
        {
        }
    }
}
