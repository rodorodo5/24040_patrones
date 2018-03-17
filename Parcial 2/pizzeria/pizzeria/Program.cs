using System;
using System.Collections.Generic;

namespace pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            pizzaFactory styleTijuas = new FactoryPizzaTijuas();
            PizzaStore miPizzaStore = new PizzaStore(styleTijuas);

            pizzaFactory styleNy = new FactoryPizzaNuevaYork();
            PizzaStore miPizzaStore2 = new PizzaStore(styleNy);
            List<String> pizzaL = new List<String> { "Peperonni", "Hawaiana", "Mexicana" };


            foreach (String pizza in pizzaL)
            {

                Pizza mipizza = miPizzaStore.makePizza(pizza);
                mipizza = new chorizo(mipizza);

                Pizza mipizza2 = miPizzaStore2.makePizza(pizza);
                mipizza2 = new carne(mipizza2);


                Console.WriteLine(mipizza.descripcion());
                Console.WriteLine(mipizza2.descripcion());
            }


            Console.ReadLine();


        }
    }
}
