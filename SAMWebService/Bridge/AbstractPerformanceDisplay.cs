using System;
using System.Collections.Generic;
using System.Text;
using SAMWebService.Bridge;
using SAMWebService.Models;

namespace SAMWebService
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
