using System;
namespace commandPattern
{
    class SleepCommand : ICommand
    {
        Receiver receiver;

        public SleepCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void execute()
        {
            Console.WriteLine("Sleep ejecutado");
            this.receiver.sleep();
        }
        public void undo()
        {
            Console.WriteLine("Sleep undo");
            this.receiver.on();
        }
    }
}
