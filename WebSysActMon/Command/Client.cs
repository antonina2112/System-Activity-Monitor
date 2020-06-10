using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSysActMon.Models;
using System.Windows.Forms;

namespace WebSysActMon.Command
{
    public class Client
    {
        private readonly Receiver Receiver;
        private readonly Invoker Invoker;
        private readonly List<MouseHookModel> mouseHooks = new List<MouseHookModel>();

        public Client()
        {
            Receiver = new Receiver();
            Invoker = new Invoker();
        }

        private MouseHookModel Run(Command command)
        {
            Invoker.StoreCommand(command);
            Invoker.ExecuteCommand();

            return Receiver.HookModel;
        }

        public List<MouseHookModel> GetMouseHooks()
        {
            return mouseHooks;
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            mouseHooks.Insert(0, Run(new MouseUpCommand(Receiver, sender, e)));
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            mouseHooks.Insert(0, Run(new MouseDownCommand(Receiver, sender, e)));
        }

        public void MouseWheel(object sender, MouseEventArgs e)
        {
            mouseHooks.Insert(0, Run(new MouseWheelCommand(Receiver, sender, e)));
        }
    }
}
