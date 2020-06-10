using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSysActMon.Command
{
    public abstract class Command
    {
            protected Receiver receiver;
            protected object sender;
            protected MouseEventArgs eventArgs;

            public abstract void Execute();
    }
}
