using System;
namespace pizzeria
{
     class FactoryPizzaNuevaYork : pizzaFactory
    {
        public FactoryPizzaNuevaYork()
        {

        }
        override public Pizza makePizza(String name)
        {
            if (name == "Peperonni")
            {
                return new stilony(new peperonni());
            }
            else if (name == "Hawaiana")
            {
                return new stilony(new hawaiana());
            }
            else if (name == "Mexicana")
            {
                return new stilony(new mexicana());
            }
            return null;
        }
    }
}
