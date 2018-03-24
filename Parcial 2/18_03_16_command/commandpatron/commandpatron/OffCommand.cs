using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class OffCommand : ICommand 
    {
        Reciever reciever;

        public OffCommand(Reciever reciever)
        {
            this.reciever = reciever;
        }
        public void execute()
        {
            Console.WriteLine("Executando Off Command");
            reciever.Off();
        }

        public void undo(){
        }
    }
}
