// unset

namespace Ex1
{
    internal abstract class FlyingTransformer : Transformer
    {
        protected FlyingTransformer(Weapon weapon, Scanner scanner) : base(weapon, scanner) { }

        public abstract void Fly();
    }
}