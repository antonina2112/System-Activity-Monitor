using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSysActMon.Models;

namespace WebSysActMon.Bridge
{
    public class MemoryPerformanceSingleton : IPerformanceSingleton
    {
        static MemoryPerformanceSingleton _memoryPerformance;
        readonly List<Performance> _performance;
        readonly Timer _timer;
        readonly PerformanceCounter _counter;
        public static IPerformanceSingleton GetInstance()
        {
            if (_memoryPerformance == null)
            {
                _memoryPerformance = new MemoryPerformanceSingleton();
            }
            return _memoryPerformance;
        }

        public MemoryPerformanceSingleton()
        {
            _counter = new PerformanceCounter("Memory", "Available MBytes");
            _performance = new List<Performance>();

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
