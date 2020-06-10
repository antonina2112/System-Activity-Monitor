using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebSysActMon.Bridge;
using WebSysActMon.Models;

namespace WebSysActMon
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "https://localhost:44390/WebService.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
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
    }
}
