using System;
namespace decorador
{
    public class chaiPay : Bebida
    {

        public chaiPay()
        {
            this.size = "Small";
        }

        public chaiPay(String size)
        {
            this.size = size;
        }

        public override string getDescription()
        {
            return this.size + " Chai";
        }

        public override double cost()
        {

            if (this.size == "Medium")
            {
                return 45;
            }
            else if (this.size == "Large")
            {
                return 55;
            }
            else
            {
                return 40;
            }
        }
    }
}
