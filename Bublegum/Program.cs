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

            //This loop makes sure that you can get a gum until there are no more left.
            do
            {
                Console.WriteLine("Get a gum by typing 5");
                int throwCoin = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your gum:");
                dispencer.CoinInput(throwCoin);
                Console.WriteLine("Remaning Gums");
                foreach (var VARIABLE in tempList)
                {
                    Console.WriteLine("Color: " + VARIABLE.Color + "Flavour: " + VARIABLE.Flavour);
                }
            } while (true);
        }
    }
}