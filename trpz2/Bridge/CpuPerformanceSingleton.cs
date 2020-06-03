using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using trpz2.Models;

namespace trpz2.Bridge
{
    public class CpuPerformanceSingleton: IPerformanceSingleton
    {
        readonly List<Performance> _performance;
        static CpuPerformanceSingleton _cpuPerformanceSingleton;
        private readonly Timer _timer;
        readonly PerformanceCounter _counter;

        public static IPerformanceSingleton GetInstance()
        {
            if (_cpuPerformanceSingleton == null)
            {
                _cpuPerformanceSingleton = new CpuPerformanceSingleton();
            }
            return _cpuPerformanceSingleton;
        }

        CpuPerformanceSingleton()
        {
            _performance = new List<Performance>();
            _counter = new PerformanceCounter("Процессор", "% загруженности процессора", "_Total");
            _timer = new Timer(Tick, null, 0, 1000);
        }

        public List<Performance> GetPerformance()
        {
            return _performance;
        }

        void Tick(object e)
        {
            _performance.Add(new Performance
            {
                Time = DateTime.Now,
                Value = _counter.NextValue()
            });
        }
    }
}
