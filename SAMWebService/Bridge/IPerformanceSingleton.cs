using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAMWebService.Models;

namespace SAMWebService.Bridge
{
    public interface IPerformanceSingleton
    {
        List<Performance> GetPerformance();
    }
}
