using System;
namespace commandPattern
{
    class OnCommand : ICommand
    {

        Receiver receiver;

        public OnCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void execute()
        {
            Console.WriteLine("Executing On Command.");
            this.receiver.on();
        }
        public void undo()
        {
            Console.WriteLine("Undoing On Command. Turning off receiver.");
            this.receiver.off();
        }
    }
}
