using System;
namespace pizzeria
{
     class PizzaStore
    {
        private pizzaFactory factory;

        public PizzaStore(pizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza makePizza(String s)
        {
            return this.factory.makePizza(s);
        }
    }
}
