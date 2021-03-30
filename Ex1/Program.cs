using System;
using System.Text;

namespace Ex1
{
    internal class Program
    {
        private static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            var optimusPrime = new OptimusPrime(new LaserWeapon(), new OpticalScanner());
            var starScream = new StarScream(new RocketLauncher(), new Sonar());
            optimusPrime.Run();
            starScream.Run();
        }
    }
}
