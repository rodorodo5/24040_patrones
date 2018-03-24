using System;
namespace commandPattern
{
    class Receiver
    {

        public Receiver()
        {

        }

        public void on()
        {
            Console.WriteLine("Receiver prendido");
        }

        public void off()
        {
            Console.WriteLine("Receiver apagado");
        }

        public void sleep()
        {
            Console.WriteLine("Receiver durmiendo");
        }

        public void reset()
        {
            Console.WriteLine("Receiver fue reseteado");
        }
    }
}
