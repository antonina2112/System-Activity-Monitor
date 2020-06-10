using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WebSysActMon.Iterator
{
    public class ProcessesCollection : IEnumerable
    {
        List<Process> Processes = new List<Process>(Process.GetProcesses());

        public IEnumerator GetEnumerator()
        {
            return new ProcessEnumerator(this);
        }

        public List<Process> GetProcesses()
        {
            return Processes;
        }
        public Process this[int index]
        {
            get { return Processes[index]; }
        }
        public int Count
        {
            get { return Processes.Count; }
        }
    }
}
