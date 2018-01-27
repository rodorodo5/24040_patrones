using System;
namespace Kingdom
{
    public class character
    {
        
        public string Name { get; set; }

        public void fight() { }
        public character() { }

        public weaponbehaviour setWeapon { get; set; }

        public character(string name, weaponbehaviour SetWeapon)
        {
            Name = name;
            setWeapon = SetWeapon;
        }

    }
}
