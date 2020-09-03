using System;
using System.Collections.Generic;

namespace Bublegum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("velkommen til tyggegummiemaskinen");
            Dispencer dispencer = new Dispencer();
            dispencer.AddGum();
            List<Gum> tempList = new List<Gum>(); 
            tempList = dispencer.GetGums();

            foreach (Gum VARIABLE in tempList)
            {
                Console.WriteLine(VARIABLE.Color);
            }


            //Console.WriteLine("Throw in your coin - it has to be 5");
            //int throwCoin = Int32.Parse(Console.ReadLine());
            //dispencer.ThrowCoin(throwCoin);
            //dispencer.GumInDisp();

            //dispencer.ListOfGums();

        }
    }
}