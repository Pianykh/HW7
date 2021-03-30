
namespace Ex1
{
    internal abstract class SwimmingTransformer : Transformer
    {
        protected SwimmingTransformer(Weapon weapon, Scanner scanner) : base(weapon, scanner) { }

        public abstract void Swim();
    }
}
