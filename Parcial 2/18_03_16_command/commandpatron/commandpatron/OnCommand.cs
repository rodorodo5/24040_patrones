using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class OnCommand : ICommand
    {
        Reciever reciever;

        public OnCommand(Reciever reciever) {
            this.reciever = reciever;
        }
        public void execute(){
            Console.WriteLine("Executando On Command");
            reciever.On();
        }

        public void undo() {

        }
    }
}
