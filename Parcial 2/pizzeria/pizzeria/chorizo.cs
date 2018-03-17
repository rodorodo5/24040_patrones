using System;
namespace pizzeria
{
    public class chorizo : Decorador
    {
        Pizza pizza;

        public chorizo(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string descripcion()
        {
            return pizza.descripcion() + ", con chorizo";
        }
    }
}
