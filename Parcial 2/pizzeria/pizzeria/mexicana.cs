using System;
namespace pizzeria
{
    public class mexicana : Pizza
    {
        public mexicana() : base() {

        }

        override public String descripcion()
        {
            return "Pizza Mexicana ";
        }
    }
}
