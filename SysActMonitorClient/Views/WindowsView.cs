using System;
using System.Collections.Generic;
using System.Text;
using SysActMonitorClient.WebService;
using trpz2.Models;
using trpz2.Visitor;

namespace SysActMonitorClient
{
    public class WindowsView
    {
        ObjectStructure windowsClient;
        public WindowsView()
        {
            windowsClient = new ObjectStructure();
            windowsClient.Add(new ListOfWindowsInfo());
            windowsClient.Accept(new OrderedListVisitor());
        }
        public void PrintWindowsInfo()
        {
            foreach (var e in windowsClient.GetWindows())
            {
                Console.WriteLine($"Id: {e.ID}, \n Title: {e.Title}");
            }
        }
    }
}
