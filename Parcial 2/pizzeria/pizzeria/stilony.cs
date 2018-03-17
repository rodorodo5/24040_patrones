using System;
namespace pizzeria
{
    public class stilony : Decorador
    {
        Pizza pizza;

        public stilony(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string descripcion()
        {
            return pizza.descripcion() + ", estilo nueva york";
        }
    }
}
