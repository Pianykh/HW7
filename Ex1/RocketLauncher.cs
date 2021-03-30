// unset

using System;

namespace Ex1
{
    internal class RocketLauncher : Weapon
    {
        public RocketLauncher()
        {
            Ammo = 1;
        }

        public override void Reload()
        {
            Console.WriteLine("Reload Rocket launcher");
            Ammo = 1;
        }

        public override void Fire()
        {
            Console.WriteLine(Ammo > 0 ? "Fire Rocket launcher" : "Rocket launcher need to reload");
            Ammo--;
        }
    }
}