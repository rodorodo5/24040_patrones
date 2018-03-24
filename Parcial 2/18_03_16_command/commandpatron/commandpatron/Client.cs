using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class Client
    {
        Invoker invoker;
        Reciever reciever;
        ICommand onCommand;
        ICommand offCommand;
        ICommand SlowCommand;
        ICommand partyCommand;
        Stack<int> actions = new Stack<int>();
        List<ICommand> commandList = new List<ICommand>();

        public Client() {
            this.invoker = new Invoker();
            this.reciever = new Reciever();
            this.onCommand = new OnCommand(reciever);
            this.offCommand = new OffCommand(reciever);
            this.SlowCommand = new SlowCommand(reciever);

            commandList.Add(this.onCommand);
            commandList.Add(this.offCommand);
            commandList.Add(this.SlowCommand);


            this.partyCommand = new PartyCommand(this.commandList);
            setCommands();
        }

        private void setCommands() {
            this.invoker.setCommand(onCommand, 0);
            this.invoker.setCommand(offCommand, 1);
            this.invoker.setCommand(SlowCommand, 3);
            this.invoker.setCommand(partyCommand, 4);
        }

        public void action(int index) {
            invoker.pressButton(index);
            actions.Push(index);
        }

        public void undoAction(int index) {
            invoker.pressUndo(actions.Pop());
        }
    }
}
