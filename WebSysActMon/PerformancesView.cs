using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WebSysActMon;
using WebSysActMon.Bridge;
using WebSysActMon.Models;


namespace SysActMWebSysActMononitor
{
    public class PerformancesView
    {
        static MemoryPerformanceSingleton memoryPerformanceSingleton = new MemoryPerformanceSingleton();
        static CpuPerformanceSingleton CpuPerformanceSingleton = new CpuPerformanceSingleton();

        public ObservableCollection<Performance> memoryPerformance { get; set; } = new ObservableCollection<Performance>();
        public ObservableCollection<Performance> cpuPerformance { get; set; } = new ObservableCollection<Performance>();

        AbstractPerformanceDisplay _memoryDisplay = 
            new MemoryPerformanceDisplay(memoryPerformanceSingleton);
        AbstractPerformanceDisplay _cpuDisplay = new CpuPerformanceDisplay(CpuPerformanceSingleton);

        List<Performance> _memoryPerformances = memoryPerformanceSingleton.GetPerformance();
        List<Performance> _cpuPerformances = CpuPerformanceSingleton.GetPerformance();

        public PerformancesView(int k)
        {
            this.UpdateChart(k);
        }

        async Task UpdateChart(int k)
        {
            while (true)
            {
                await Task.Delay(1000);
                memoryPerformance = new ObservableCollection<Performance>(_memoryDisplay.GetPerformance());
                cpuPerformance = new ObservableCollection<Performance>(_cpuDisplay.GetPerformance());
                if (k==1)
                {
                    this.PrintMemory();
                }
                else
                {
                    this.PrintCPU();
                }
            }
        }

        public void PrintMemory() 
        {
            foreach (Performance p in _memoryPerformances)
            {
                Console.WriteLine($"Memory performance time: {p.Time}, \n performance value: {p.Value}");
            }
        }

        public void PrintCPU()
        {
            foreach (Performance p in _cpuPerformances)
            {
                Console.WriteLine($"CPU performance time: {p.Time}, \n performance value: {p.Value}");
            }
        }
        public void Add(Performance p, int k)
        {
            if (k == 1)
            {
                memoryPerformance.Add(p);
            }
            else
            {
                cpuPerformance.Add(p);
            }
        }
    }
}
