using System;
namespace decorador.Models
{
    public class payLatte : Bebida
    {
        public payLatte()
        {
            this.size = "Small";
        }

        public payLatte(String size)
        {
            this.size = size;
        }

        public override string getDescription()
        {
            return this.size + " Latte";
        }

        public override double cost()
        {
            if (this.size == "Medium")
            {
                return 45;
            }
            else if (this.size == "Large")
            {
                return 65;
            }
            else
            {
                return 40;
            }
        }
       
    }
}
