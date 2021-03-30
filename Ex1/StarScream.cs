// unset

using System;

namespace Ex1
{
    internal class StarScream : FlyingTransformer
    {
        public StarScream(Weapon weapon, Scanner scanner) : base(weapon, scanner) { }

        public override void Fire()
        {
            Weapon.Fire();
        }

        public override void ReloadWeapon()
        {
            Weapon.Reload();
        }

        public override void Transform()
        {
            IsVehicle = !IsVehicle;
            Console.WriteLine("StarScream transform");
        }

        public override void Run()
        {
            Console.WriteLine(!IsVehicle ? "StarScream run" : "StarScream can not run in current form");
        }

        public override void FindEnemy()
        {
            Scanner.Scan();
        }

        public override void Fly()
        {
            Console.WriteLine(IsVehicle ? "StarScream drive" : "StarScream can not drive in current form");
        }
    }
}