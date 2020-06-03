using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trpz2.Models;
using System.Windows.Forms;

namespace trpz2.Command
{
    public class Receiver
    {
        public MouseHookModel HookModel { get; private set; }
        public MouseEvents MouseEvent { private get; set; }

        public void Run(object sender, MouseEventArgs e)
        {
            switch (MouseEvent)
            {
                case MouseEvents.MouseDown:
                    HookModel = AddMouseEvent("Mouse Down", e.Button.ToString(), e.X.ToString(), e.Y.ToString());
                    break;
                case MouseEvents.MouseUp:
                    HookModel = AddMouseEvent("Mouse Up", e.Button.ToString(), e.X.ToString(), e.Y.ToString());
                    break;
                case MouseEvents.MouseWheel:
                    HookModel = AddMouseEvent("Mouse Wheel", "", "", "");
                    break;
                default:
                    break;
            }
        }

        private MouseHookModel AddMouseEvent(string eventType, string button, string x, string y)
        {
            return new MouseHookModel
            {
                EventType = eventType,
                Button = button,
                X = x,
                Y = y
            };
        }
    }
}
