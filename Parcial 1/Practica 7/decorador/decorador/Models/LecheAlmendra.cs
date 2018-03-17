using System;
namespace decorador.Models
{
    public class LecheAlmendra : Ingredientes
    {

        Bebida bebida;

        public LecheAlmendra(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override string getDescription()
        {
            return bebida.getDescription() + " con leche de almendra";
        }

        public override double cost()
        {
            if (bebida.size == "Medium")
            {
                return bebida.cost() + 10;
            }
            else if (bebida.size == "Large")
            {
                return bebida.cost() + 15;
            }
            else
            {
                return bebida.cost() + 9;
            }
        }
       
    }
}
