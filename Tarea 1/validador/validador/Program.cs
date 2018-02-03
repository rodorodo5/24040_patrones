using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validador {
    class Program {
        static void Main(string[] args) {

            validar_email email = new validar_email();
            validar_numero numero = new validar_numero();

            string_flied numero1 = new string_flied(numero, "1010101010101020202020");
            string_flied numero2 = new string_flied(numero, "woow");
            string_flied email1 = new string_flied(email, "rodolfo@gmail.com");
            string_flied email2 = new string_flied(email, "memesaurio.com");


            Console.WriteLine("\n- Validar Email -\n");
            email1.testMessage();
            email2.testMessage();

            Console.WriteLine("\n- Validar Numeros -\n");
            numero1.testMessage();
            numero2.testMessage();
            Console.ReadKey();
        }
    }
}
