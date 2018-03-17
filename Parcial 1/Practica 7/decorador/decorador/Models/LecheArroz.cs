using System;
namespace decorador.Models
{
    public class LecheArroz : Ingredientes
    {

        Bebida bebida;

        public LecheArroz(Bebida bebida)
        {
            this.bebida = bebida;
        }

        public override string getDescription()
        {
            return bebida.getDescription() + " con leche de arroz";
        }

        public override double cost()
        {
            if (bebida.size == "Medium")
            {
                return bebida.cost() + 9;
            }
            else if (bebida.size == "Large")
            {
                return bebida.cost() + 10;
            }
            else
            {
                return bebida.cost() + 8;
            }
        }
    }
}
