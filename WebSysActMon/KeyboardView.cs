using Caliburn.Micro;
using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;
using WebSysActMon.Models;

namespace WebSysActMon
{
    public class KeyboardView:Screen
    {
        //ObservableCollection<KeyboardHookModel> keyboardHookModels;

        //public ObservableCollection<KeyboardHookModel> KeyboardEvents
        //{
        //    get { return keyboardHookModels; }
        //    set
        //    {
        //        keyboardHookModels = value;
        //    //    NotifyOfPropertyChange(() => KeyboardEvents);
        //    }
        //} = new ObservableCollection<KeyboardHookModel>();

        public KeyboardView(List<KeyboardHookModel> keyboardHooks)
        {

            _ = UpdateInfo(keyboardHooks);
        }

        async Task UpdateInfo(List<KeyboardHookModel> keyboardHooks)
        {
            while (true)
            {
                await Task.Delay(10);
                //keyboardHooks = new List<KeyboardHookModel>(HookSingleton.GetInstance().GetKeyboardHooks());
                PrintKeyboardEvents(keyboardHooks);

            }

        }
        //public ObservableCollection<KeyboardHookModel> GetCollection()
        //{
        //    return KeyboardEvents;
        //}
        public void PrintKeyboardEvents(List<KeyboardHookModel> keyboardHooks)
        {
            foreach (var k in keyboardHooks)
            {
                Console.WriteLine($"Event Type:  {k.EventType}, \n Key char: {k.KeyChar}, \n Time:   {k.Time}");
            }
        }
    }
}
