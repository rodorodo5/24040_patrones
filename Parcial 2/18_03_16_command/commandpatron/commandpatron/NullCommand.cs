using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class NullCommand
    {
        Reciever reciever;

        public NullCommand(Reciever reciever)
        {
            this.reciever = reciever;
        }
        public void execute()
        {
            Console.WriteLine("Command is null");
        }

        public void undo()
        {
        }
    }
}
