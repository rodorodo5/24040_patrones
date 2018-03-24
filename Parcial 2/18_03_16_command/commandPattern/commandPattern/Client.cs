using System;
namespace commandPattern
{
    class Client
    {

        private Invoker invoker;
        private Receiver receiver;

        public Client()
        {
            this.invoker = new Invoker(5);
            this.receiver = new Receiver();
            setCommands();
        }

        private void setCommands()
        {
            this.invoker.setCommand(new OnCommand(this.receiver), 0);
            this.invoker.setCommand(new OffCommand(this.receiver), 1);
            this.invoker.setCommand(new ResetCommand(this.receiver), 2);
            this.invoker.setCommand(new SleepCommand(this.receiver), 3);
        }
        public void doAction(int index)
        {
            Console.WriteLine("\nCliente corriendo comando en:  " + index);
            this.invoker.invoke(index);
        }
    }
}
