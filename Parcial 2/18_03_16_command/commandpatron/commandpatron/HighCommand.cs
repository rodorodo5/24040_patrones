using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class HighCommand : ICommand
    {
        Reciever reciever;

        public HighCommand(Reciever reciever)
        {
            this.reciever = reciever;
        }
        public void execute()
        {
            Console.WriteLine("Executando OFF - high");
            reciever.On();
        }

        public void undo()
        {
        }
    }
}
