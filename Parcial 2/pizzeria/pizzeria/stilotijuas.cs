using System;
namespace pizzeria
{
    public class stilotijuas : Decorador
    {
        Pizza pizza;

        public stilotijuas(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string descripcion()
        {
            return pizza.descripcion() + ", estilo Tijuana";
        }
    }
}
