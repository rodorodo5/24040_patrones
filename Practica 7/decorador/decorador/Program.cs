using System;
using decorador.Models;

namespace decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new payucaExpress("Large");
            Console.WriteLine(bebida.getDescription() + " " +  bebida.cost());

            bebida = new LecheAlmendra(bebida);
            Console.WriteLine(bebida.getDescription() + " " +   bebida.cost());

            bebida = new LecheArroz(bebida);
            Console.WriteLine(bebida.getDescription() + " " +  bebida.cost());

            Bebida bebida2 = new chaiPay();
            Console.WriteLine(bebida2.getDescription() +" "+  bebida2.cost());

            Console.ReadLine();
        }
    }
}
