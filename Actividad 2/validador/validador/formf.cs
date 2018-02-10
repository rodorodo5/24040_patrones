using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validador {
    abstract class validador : IValidable {
        public IValidable tipo_validacion;
        public bool isValid;
        public string value;
        
        public abstract bool validate(String value);
    }
}
