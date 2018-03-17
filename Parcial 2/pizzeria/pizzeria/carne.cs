using System;
namespace pizzeria
{
    public class carne : Decorador
    {
        Pizza pizza;

        public carne(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override string descripcion()
        {
            return pizza.descripcion() + ", con Carne";
        }
    }
}
