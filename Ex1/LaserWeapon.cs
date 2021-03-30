// unset

using System;

namespace Ex1
{
    internal class LaserWeapon : Weapon
    {
        public LaserWeapon()
        {
            Ammo = 5;
        }
        
        public override void Reload()
        {
            Console.WriteLine("Reload Laser weapon");
            Ammo = 5;
        }

        public override void Fire()
        {
            Console.WriteLine(Ammo > 0 ? "Fire Laser weapon" : "Laser weapon need to reload");
            Ammo--;
        }
    }
}