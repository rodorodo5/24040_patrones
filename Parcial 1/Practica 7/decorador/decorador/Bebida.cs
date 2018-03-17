using System;
namespace decorador
{
    public abstract class Bebida
    {
            public String size { get; set; }
            public abstract double cost();
            public abstract String getDescription();

    }
}
