
namespace Ex1
{
    internal abstract class Transformer
    {
        protected bool IsVehicle;
        protected readonly Weapon Weapon;
        protected readonly Scanner Scanner;

        protected Transformer(Weapon weapon, Scanner scanner)
        {
            Weapon = weapon;
            Scanner = scanner;
        }
        public abstract void Fire();

        public abstract void ReloadWeapon();

        public abstract void Transform();

        public abstract void Run();

        public abstract void FindEnemy();
    }
}
