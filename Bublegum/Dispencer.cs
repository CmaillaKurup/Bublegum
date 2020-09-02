using System;
using System.Collections.Generic;

namespace Bublegum
{
    public class Dispencer
    {
        //default constructor
        public Dispencer()
        {
            
        }
        
        Gum gum = new Gum("foo","foo1");
        List<Gum> gumInDisp = new List<Gum>();
        Random rand = new Random();
        
        //This methode makes 55 new gums randomly, so it do not follow the task completly
        public void GumInDisp()
        {
            for (int i = 0; i < 55; i++)
            {
                switch (rand.Next(1, 5))
                {
                    case 1:
                        gumInDisp.Add(new Gum("Red", "Strawberry"));
                        break;
                    case 2:
                        gumInDisp.Add(new Gum("Blue", "Mint"));
                        break;
                    case 3:
                        gumInDisp.Add(new Gum("Green", "Watermelon"));
                        break;
                    case 4:
                        gumInDisp.Add(new Gum("Yellow", "Lemon"));
                        break;
                    default:
                        break;
                }
            }
        }

        private int count = 1;
        
        //makes sure that the child only ar abel to throw in with a coin at size 5 nor smaller or bigger
        public void ThrowCoin(int throwCoin)
        {
            while (throwCoin != 5)
            {
                count = count + 1;
                
                if (throwCoin > 5)
                {
                    Console.WriteLine("to big");
                }
                if (throwCoin < 5)
                {
                    Console.WriteLine("to small");
                }

                throwCoin = int.Parse(Console.ReadLine());
            }

            if (throwCoin == 5)
            {
                Console.WriteLine("gum");
            }
        }
    }
}