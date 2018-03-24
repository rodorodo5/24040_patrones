using System;
namespace commandPattern
{
    class ResetCommand : ICommand
    {

        Receiver receiver;

        public ResetCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void execute()
        {
            Console.WriteLine("Commando reset siendo ejecutado");
            this.receiver.reset();
        }
        public void undo()
        {
            Console.WriteLine("Undo activado apagandor recibidor");
            this.receiver.off();
        }
    }
}
