using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class PartyCommand : ICommand
    {
        List<ICommand> commandList;

        public PartyCommand(List<ICommand> commandList)
        {
            this.commandList = commandList;
        }
        public void execute()
        {
            Console.WriteLine("Ejecutando Party Command ");
            foreach (ICommand command in this.commandList) 
                command.execute();
        }

        public void undo()
        {
            Console.WriteLine("Undo Party Command ");
            this.commandList.Reverse();
            foreach (ICommand command in this.commandList)
                command.undo();
        }
    }
}
