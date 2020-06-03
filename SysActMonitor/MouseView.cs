using Caliburn.Micro;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading.Tasks;
using trpz2.Models;
using System;

namespace SysActMonitor
{
    public class MouseView:Screen
    {
        //ObservableCollection<MouseHookModel> mouseHookModels;

        //public ObservableCollection<MouseHookModel> MouseEvents
        //{
        //    get { return mouseHookModels; }
        //    set
        //    {
        //        mouseHookModels = value;
        //        NotifyOfPropertyChange(() => MouseEvents);
        //    }
        //}

        //public MouseView()
        //{
        //    _ = UpdateInfo();
        //}

        //async Task UpdateInfo()
        //{
        //    while (true)
        //    {
        //        await Task.Delay(10);
        //        MouseEvents = new ObservableCollection<MouseHookModel>(HookSingleton.GetInstance().GetMouseHooks());
        //        PrintMouseEvents();
        //    }
        //}
        //public ObservableCollection<MouseHookModel> GetCollection()
        //{
        //    return MouseEvents;
        //}
        public void PrintMouseEvents(List<MouseHookModel> mouseHooks)
        {
            foreach (var m in mouseHooks)
            {
                Console.WriteLine($"Event Type:  {m.EventType}, \n Button: {m.Button}, \n X:   {m.X}, Y:   {m.Y}");
            }
        }

    }
}
