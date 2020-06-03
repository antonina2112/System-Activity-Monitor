using System;
using System.Collections.Generic;
using System.Text;
using trpz2.Bridge;
using trpz2.Models;

namespace trpz2
{
    public abstract class AbstractPerformanceDisplay
    {
        protected IPerformanceSingleton _performanceSingleton;

        public AbstractPerformanceDisplay(IPerformanceSingleton performanceSingleton)
        {
            _performanceSingleton = performanceSingleton;
        }

        public virtual List<Performance> GetPerformance()
        {
            return _performanceSingleton.GetPerformance();
        }
    }
}
