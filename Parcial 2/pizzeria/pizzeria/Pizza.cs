using System;
namespace pizzeria
{
    public abstract class Pizza
    {
        public String style { get; set; }

        public Pizza(){}

        abstract public String descripcion();

        public void cortada()
        {

        }
        public void caja()
        {

        }
        public void cocinada()
        {

        }

    }
}
