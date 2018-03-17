using System;
namespace decorador
{
    public class payucaExpress : Bebida
    {
        
        public payucaExpress()
        {
            this.size = "Small";
        }

        public payucaExpress(String size)
        {
            this.size = size;
        }

        public override string getDescription()
        {
            return this.size + " Expresso";
        }

        public override double cost()
        {
            if (this.size == "Medium")
            {
                return 50;
            }
            else if (this.size == "Large")
            {
                return 56;
            }
            else
            {
                return 45;
            }
        }


    }
}
