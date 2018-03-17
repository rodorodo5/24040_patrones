using System;
namespace pizzeria
{
    public abstract class pizzaFactory
    {
        public pizzaFactory(){}
        abstract public Pizza makePizza(String name);
    }
}
