using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMWebService.Command
{
    public class MouseDownCommand:Command
    {
        public MouseDownCommand(Receiver receiver, object sender, MouseEventArgs eventArgs)
        {
            this.receiver = receiver;
            this.sender = sender;
            this.eventArgs = eventArgs;
        }

        public override void Execute()
        {
            receiver.MouseEvent = MouseEvents.MouseDown;
            receiver.Run(sender, eventArgs);
        }
    }
}
