using System;
namespace decorador.Models
{
    public class PayMocha : Bebida
    {
        public PayMocha()
        {
            this.size = "Small";
        }

        public PayMocha(String size)
        {
            this.size = size;
        }

        public override string getDescription()
        {
            return this.size + " Mocha";
        }

        public override double cost()
        {
            if (this.size == "Medium")
            {
                return 40;
            }
            else if (this.size == "Large")
            {
                return 35;
            }
            else
            {
                return 50;
            }
        }
    }
}
