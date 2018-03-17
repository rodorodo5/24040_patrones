using System;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminarManos = new CaminarManos();
            var noCaminar = new NoCaminar();
            var rodo = new student();

            rodo.walkableBehaviour = caminarManos;
            rodo.walkableBehaviour.walk();
            //Changing behavoir
            rodo.walkableBehaviour = noCaminar;
            rodo.walkableBehaviour.walk();

            Console.ReadLine();

        }
    }
}
