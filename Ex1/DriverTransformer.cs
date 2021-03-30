// unset

namespace Ex1
{
    internal abstract class DriverTransformer : Transformer
    {
        protected DriverTransformer(Weapon weapon, Scanner scanner) : base(weapon, scanner) { }

        public abstract void Drive();
    }
}