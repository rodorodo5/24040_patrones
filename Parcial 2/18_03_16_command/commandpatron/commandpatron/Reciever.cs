using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class Reciever
    {

        public void On() {
            Console.WriteLine("On command ejecutado");
        }

        public void Off() {
            Console.WriteLine("Off command ejecutado");
        }

        public void Slow()
        {
            Console.WriteLine("Slow command ejecutado");
        }

        public void Medium()
        {
            Console.WriteLine("Medium command ejecutado");
        }

        public void High()
        {
            Console.WriteLine("High command ejecutado");
        }
    }
}
