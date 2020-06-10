using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;


namespace WebSysActMon
{
    class MyProcesses
    {
        List<Process> processes = new List<Process>(Process.GetProcesses());
        public ObservableCollection<Process> Processes { get; set; } = new ObservableCollection<Process>();

        public List<Process> GetProcesses()
        {
            return processes;
        }

        public void PrintProcesses()
        {
            foreach (Process process in processes)
            {
                Console.WriteLine($"Process ID: {process.Id}, \n Process name: {process.ProcessName}");
            }
        }

        public void Add(Process p)
        {
            Processes.Add(p);
        }
    }
}
