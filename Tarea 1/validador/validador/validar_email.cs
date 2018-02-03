using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validador {
    class validar_email : IValidable {
        public bool validate(String value) {
            return value.Contains('@');
        }
    }
}
