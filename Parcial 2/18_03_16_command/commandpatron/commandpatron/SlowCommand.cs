using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class SlowCommand : ICommand
    {
        Reciever reciever;

        public SlowCommand(Reciever reciever)
        {
            this.reciever = reciever;
        }
        public void execute()
        {
            Console.WriteLine("Executando Slow Command");
            reciever.Slow();
        }

        public void undo()
        {
        }
    }
}
