using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_03_16_Command_01
{
    interface ICommand
    {
        void execute();
        void undo(); 
    }
}
