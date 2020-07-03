using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysActMonitorClient.SAMlocalhost;


namespace SysActMonitorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //HookSingleton hook = HookSingleton.GetInstance();
            Console.WriteLine("Hello World!");
            WindowsView windows = new WindowsView();
            windows.PrintWindowsInfo();


            //Console.WriteLine("1 - Memory performance, 2 - Cpu performance");
            //int k = Convert.ToInt32(Console.ReadLine());
            //PerformancesView performances = new PerformancesView(k);



            //foreach (Performance p in performances.memoryPerformance)
            //{
            //    performances.Add(p, k);
            //}
            //foreach (Performance p in performances.cpuPerformance)
            //{
            //    performances.Add(p, k);
            //}

            //Console.WriteLine("1 - Mouse, 2 - Keyboard");
            //int t = Convert.ToInt32(Console.ReadLine());
            //if (t == 1)
            //{
            //    Client client = new Client();
            //    List<MouseHookModel> mouseHooks = new List<MouseHookModel>();
            //    mouseHooks = client.GetMouseHooks();
            //    MouseView mouseview = new MouseView();
            //    mouseview.PrintMouseEvents(mouseHooks);
            //}
            //else
            //{
            //    List<KeyboardHookModel> keyboardHooks = new List<KeyboardHookModel>();
            //    keyboardHooks = hook.GetKeyboardHooks();
            //    KeyboardView keyboardView = new KeyboardView(keyboardHooks);
            //}


            Console.ReadKey();
        }
    }
}
