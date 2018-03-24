using System;
namespace commandPattern
{
    class NoCommand : ICommand
    {
        public NoCommand()
        {

        }

        public void execute()
        {
            Console.WriteLine("El comando no fue implemetnado");
        }

        public void undo()
        {
            Console.WriteLine("No Command -> Nada a que hacerle undo");
        }
    }
}
