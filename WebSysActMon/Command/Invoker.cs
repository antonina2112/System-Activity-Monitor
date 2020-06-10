using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSysActMon.Command
{
    public class Invoker
    {
        private readonly List<Command> commands = new List<Command>();
        private int current = 0;

        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }
    }
}
