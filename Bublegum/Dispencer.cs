using System;
using System.Collections.Generic;

namespace Bublegum
{
    public class Dispencer
    {
        public static List<Gum> gums = new List<Gum>();
        private int count = 1;
        Random rand = new Random();
        
        public void AddGum()
        {
            for (int i = 0; i < 55; i++)
            {
                switch (rand.Next(1, 5))
                {
                    case 1:
                        gums.Add(new Gum("Red", "Strawberry"));
                        break;
                    case 2:
                        gums.Add(new Gum("Blue", "Mint"));
                        break;
                    case 3:
                        gums.Add(new Gum("Green", "Watermelon"));
                        break;
                    case 4:
                        gums.Add(new Gum("Yellow", "Lemon"));
                        break;
                    default:
                        break;
                }
            }
        }

        public List<Gum> GetGums()
        {
            return gums;
        }
        
        public void CoinInput(int throwCoin)
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
                int randGum = rand.Next(gums.Count);
                
                Console.WriteLine(gums[randGum].Color + " " + gums[randGum].Flavour);
                gums.Remove(gums[randGum]);
            }
        }
        
        public int RemainingGums()
        {
            int a;
            a = gums.Count;

            return a;
        }
    }
}