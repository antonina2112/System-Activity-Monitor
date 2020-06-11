using System;
using System.Collections.Generic;
using System.Text;

namespace SAMWebService.Bridge
{
    public class CpuPerformanceDisplay: AbstractPerformanceDisplay
    {
        public CpuPerformanceDisplay(IPerformanceSingleton performanceSingleton) : base(performanceSingleton)
        {
        }
    }
}
