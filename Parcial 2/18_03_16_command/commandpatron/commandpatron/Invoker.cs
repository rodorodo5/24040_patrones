using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class Invoker
    {
        ICommand [] commands;

        public Invoker() {
            this.commands = new ICommand[8];
        }
        public void setCommand(ICommand command, int index) {
            this.commands[index] = command;
        }

        public void pressButton(int index) {
            commands[index].execute();
        }

        public void pressUndo(int index) {
            commands[index].undo();
        }
    }
}
