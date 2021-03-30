// unset

using System;

namespace Ex1
{
    internal class OptimusPrime : DriverTransformer
    {
        public OptimusPrime(Weapon weapon, Scanner scanner) : base(weapon, scanner) { }

        public override void Drive()
        {
            Console.WriteLine( IsVehicle ? "Optimus Prime drive" : "Optimus Prime can not drive in current form");
        }

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
            Console.WriteLine("Optimus Prime transform");
        }

        public override void Run()
        {
            Console.WriteLine(!IsVehicle ? "Optimus Prime run" : "Optimus Prime can not run in current form");
        }

        public override void FindEnemy()
        {
            Scanner.Scan();
        }

        
    }
}