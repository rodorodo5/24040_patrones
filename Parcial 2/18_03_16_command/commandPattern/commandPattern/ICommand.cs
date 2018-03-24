using System;
namespace commandPattern
{
    interface ICommand
    {
        void execute();
        void undo();
    }
}
