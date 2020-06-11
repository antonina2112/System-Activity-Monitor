using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using SysActMonitorClient.SAMlocalhost;
//using trpz2.Models;
//using trpz2.Visitor;

namespace SysActMonitorClient
{
    public class WindowsView
    {
        private readonly SAMService service = new SAMService();
        private List<WindowInfo> _windows;
        public WindowsView()
        {
            _windows = service.GetOpenWindows().ToList();
        }
        //ObjectStructure windowsClient;
        //public WindowsView()
        //{
        //    windowsClient = new ObjectStructure();
        //    windowsClient.Add(new ListOfWindowsInfo());
        //    windowsClient.Accept(new OrderedListVisitor());
        //}
        public void PrintWindowsInfo()
        {
            foreach (var e in service.GetOpenWindows())
            {
                Console.WriteLine($"Id: {e.ID}, \n Title: {e.Title}");
            }
        }
    }
}
