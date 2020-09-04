using System;
using System.Collections.Generic;

namespace Bublegum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gum> tempList = new List<Gum>();
            Dispencer dispencer = new Dispencer();
            dispencer.AddGum();
            tempList = dispencer.GetGums();
            int a = dispencer.RemainingGums();

            do
            {
                int throwCoin = Int32.Parse(Console.ReadLine());
                dispencer.CoinInput(throwCoin);
                Console.WriteLine(a);
            } while (true);
        }
    }
}