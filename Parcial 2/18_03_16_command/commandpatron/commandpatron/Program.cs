using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====== Command Pattern ======");
            Client cl = new Client();
            cl.action(4);

            Console.WriteLine("====== Command Pattern ======");
            Console.ReadKey();
        }
    }
}
