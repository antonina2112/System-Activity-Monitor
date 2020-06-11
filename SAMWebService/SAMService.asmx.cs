using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SAMWebService.Models;
using SAMWebService.Bridge;
using SAMWebService.Visitor;


namespace SAMWebService
{
    /// <summary>
    /// Сводное описание для SAMService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class SAMService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        readonly AbstractPerformanceDisplay _memoryDisplay = new MemoryPerformanceDisplay(MemoryPerformanceSingleton.GetInstance());
        readonly AbstractPerformanceDisplay _cpuDisplay = new CpuPerformanceDisplay(CpuPerformanceSingleton.GetInstance());

        [WebMethod]
        public List<Performance> GetMemoryPerformance()
        {
            return _memoryDisplay.GetPerformance();
        }

        [WebMethod]
        public List<Performance> GetCpuPerformance()
        {
            return _cpuDisplay.GetPerformance();
        }

        [WebMethod]
        public List<WindowInfo> GetOpenWindows()
        {
            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Add(new ListOfWindowsInfo());
            objectStructure.Accept(new OrderedListVisitor());

            var windows = objectStructure.GetWindows();

            return windows;
        }
    }
}
