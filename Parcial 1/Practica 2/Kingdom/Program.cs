using System;

namespace Kingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            var useKinfe = new knifeBehaviour();
            var useAxe = new axeBehaviour();
            var KnightRodo = new knight();

            KnightRodo.setWeapon = useKinfe;
            KnightRodo.setWeapon.useWeapon();
            //Changing behavoir
            KnightRodo.setWeapon = useAxe;
            KnightRodo.setWeapon.useWeapon();

            Console.ReadLine();
        }
    }
}
