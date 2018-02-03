using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validador {
    interface IValidable {
        bool validate(string value);
    }
}
