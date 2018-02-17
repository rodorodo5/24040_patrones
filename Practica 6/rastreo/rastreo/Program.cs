using System;
using rastreo.Modules;

namespace rastreo
{
    class Program
    {
        static void Main(string[] args)
        {
            DHL dhl = new DHL();
            Fedex fed = new Fedex();
            CorreoMexico correo = new CorreoMexico();

            clientA clca = new clientA();
            clientB clcb = new clientB();
            clientC clcc = new clientC();

            dhl.add(clca);
            fed.add(clcb);
            correo.add(clcc);
            correo.add(clca);

            Console.ReadKey();

        }
    }
}
