using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validador {
    class string_flied : validador {
        public string_flied(IValidable validationType, string value) : base() {
            this.tipo_validacion = validationType;
            this.value = value;
        }
        override public bool validate(String value) {
            return tipo_validacion.validate(value);
        }
        public void testMessage() {
            Console.WriteLine(this.value + " Tipo correcto? " + this.validate(this.value));
        }
    }
}
