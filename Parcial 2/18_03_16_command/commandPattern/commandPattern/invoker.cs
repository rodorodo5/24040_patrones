using System;
namespace commandPattern
{
    class Invoker
    {

        ICommand[] commands;
        int commandCount;

        public Invoker(int commandCount)
        {
            Console.WriteLine("Invoker initialized with " + commandCount + " commands.");
            this.commandCount = commandCount;
            this.commands = new ICommand[commandCount];
            initializeCommands();
        }

        private void initializeCommands()
        {
            for (int i = 0; i < this.commandCount; i++)
            {
                setCommand(new NoCommand(), i);
            }
        }

        public void setCommand(ICommand command, int index)
        {
            if (index < this.commandCount)
            {
                this.commands[index] = command;
            }
            else
            {
                Console.WriteLine("Set Command Error: Index out of range.");
            }
        }

        public void invoke(int index)
        {
            if (index < this.commandCount)
            {
                commands[index].execute();
            }
            else
            {
                Console.WriteLine("Invoke Error: Index out of range.");
            }
        }
    }
}
