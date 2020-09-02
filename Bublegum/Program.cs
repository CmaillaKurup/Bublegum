using System;

namespace Bublegum
{
    class Program
    {
        static void Main(string[] args)
        {
            Gum gum = new Gum("","");
            Dispencer dispencer = new Dispencer();
            
            Console.WriteLine("Throw in your coin - it has to be 5");
            int throwCoin = Int32.Parse(Console.ReadLine());
            dispencer.ThrowCoin(throwCoin);
            
        }
    }
}