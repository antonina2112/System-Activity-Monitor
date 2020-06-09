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
        readonly AbstractPerformanceDisplay _memoryDisplay = new MemoryPerformanceDisplay(MemoryPerformanceSingleton.GetInstance());
        readonly AbstractPerformanceDisplay _cpuDisplay = new CpuPerformanceDisplay(CpuPerformanceSingleton.GetInstance());

        

        public ObservableCollection<Performance> memoryPerformance { get; set; } = new ObservableCollection<Performance>();
        public ObservableCollection<Performance> cpuPerformance { get; set; } = new ObservableCollection<Performance>();

        //List<Performance> _cpuPerformances = cpuPerformanceSingleton.GetPerformance();

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
                    PrintMemory();
                }
                else
                {
                    PrintCpu();
                }
                //CpuPerformance = new ObservableCollection<Performance>(Service.GetCpuPerformance());
            }
        }

        public void PrintMemory() 
        {
            foreach (Performance p in _memoryDisplay.GetPerformance())
            {
                Console.WriteLine($"Memory performance time: {p.Time}, \n performance value: {p.Value}");
            }
        }

        public void PrintCpu()
        {
            foreach (Performance p in _cpuDisplay.GetPerformance())
            {
                Console.WriteLine($"Cpu performance time: {p.Time}, \n performance value: {p.Value}");
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
