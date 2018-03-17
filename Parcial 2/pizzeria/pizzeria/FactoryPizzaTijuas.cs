using System;
namespace pizzeria
{
     class FactoryPizzaTijuas : pizzaFactory
    {
        public FactoryPizzaTijuas() 
        {
        }

        override public Pizza makePizza(String name)
        {
            if (name == "Peperonni")
            {
                return new stilotijuas(new peperonni());
            }
            else if (name == "Hawaiana")
            {
                return new stilotijuas(new hawaiana());
            }
            else if (name == "Mexicana")
            {
                return new stilotijuas(new mexicana());
            }
            return null;
        }
    }
}
