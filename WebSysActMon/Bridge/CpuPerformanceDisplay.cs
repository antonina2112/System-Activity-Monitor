using System;
using System.Collections.Generic;
using System.Text;

namespace WebSysActMon.Bridge
{
    public class CpuPerformanceDisplay: AbstractPerformanceDisplay
    {
        public CpuPerformanceDisplay(IPerformanceSingleton performanceSingleton) : base(performanceSingleton)
        {
        }
    }
}
