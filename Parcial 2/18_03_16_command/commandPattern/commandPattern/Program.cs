using System;

namespace commandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Client cl = new Client();
            cl.doAction(0);
            cl.doAction(1);
            cl.doAction(2);
            cl.doAction(3);
            cl.doAction(4);
            cl.doAction(5);
            Console.ReadKey();
        }
    }
}
