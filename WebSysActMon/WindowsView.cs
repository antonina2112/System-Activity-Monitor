using System;
using System.Collections.Generic;
using System.Text;
using WebSysActMon.Models;
using WebSysActMon.Visitor;

namespace WebSysActMon
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
