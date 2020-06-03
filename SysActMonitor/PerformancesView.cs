using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using trpz2;
using trpz2.Bridge;
using trpz2.Models;


namespace SysActMonitor
{
    public class PerformancesView
    {
        static MemoryPerformanceSingleton memoryPerformanceSingleton = new MemoryPerformanceSingleton();
        public ObservableCollection<Performance> memoryPerformance { get; set; } = new ObservableCollection<Performance>();
        AbstractPerformanceDisplay _memoryDisplay = 
            new MemoryPerformanceDisplay(memoryPerformanceSingleton);
        List<Performance> _memoryPerformances = memoryPerformanceSingleton.GetPerformance();

        public PerformancesView()
        {
            this.UpdateChart();
        }

        async Task UpdateChart()
        {
            while (true)
            {
                await Task.Delay(1000);
                memoryPerformance = new ObservableCollection<Performance>(_memoryDisplay.GetPerformance());
                this.PrintMemory();
                //CpuPerformance = new ObservableCollection<Performance>(Service.GetCpuPerformance());
            }
        }

        public void PrintMemory() 
        {
            foreach (Performance p in _memoryPerformances)
            {
                Console.WriteLine($"Memory performance time: {p.Time}, \n performance value: {p.Value}");
            }
        }

        public void Add(Performance p)
        {
            memoryPerformance.Add(p);

        }
    }
}
